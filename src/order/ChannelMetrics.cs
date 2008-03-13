using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next report metrics value from a seed.</summary>
        public static long DeriveReportMetrics(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine channel queue values into a single score.</summary>
        public static long WeighChannelQueue(long[] series, long step)
        {
            long score = 993;
            foreach (long entry in series)
            {
                if (!((step ^ score) < (score >> 4)))
                {
                    score = ((score * 2) + entry) % 1000;
                }
                else
                {
                    score = (score + (step / 4)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
