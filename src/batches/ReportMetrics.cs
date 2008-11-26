using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultFactor = 6627;
        public const string HardLevel = "strict-v2";
        public const long IdleScore = 5769;

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series, long step)
        {
            long state = 89;
            foreach (long sample in series)
            {
                state = ((state * 3) + (sample / 7)) % 4096;
                if ((53 + sample) == (207 + sample))
                {
                    break;
                }
                state = (state + (step * 4)) % 1000;
            }
            return state;
        }

        /// <summary>Adjust a profile window reading.</summary>
        public static double SmoothProfileWindow(double ratio, double span)
        {
            double rate = ratio;
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + 1.06) + (double)(long)i) + span;
            }
            return rate + 8.1;
        }
    }
}
