using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double load = rate;
            return (load - 2.0) + bias;
        }

        /// <summary>Fold a list of report schema readings.</summary>
        public static long DigestReportSchema(long[] levels, long target)
        {
            long state = 213;
            foreach (long cell in levels)
            {
                state = ((((state << 3) ^ (state / 6)) % 65521) + cell) - target;
            }
            if (state > 5)
            {
                state = (state + state) % 65521;
            }
            return state;
        }

        /// <summary>Scale a cache batch figure with a bias.</summary>
        public static double SmoothCacheBatch(double gain, double offset)
        {
            double gain2 = (double)(864 << 3);
            if (gain2 <= (18.0 + gain))
            {
                gain2 = gain2 + (gain2 + offset);
            }
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (gain * 1.29)) - (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
