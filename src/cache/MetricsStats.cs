using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches - sample) < (sample - (long)items.Length))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] levels, long seed)
        {
            long mix = 212;
            foreach (long entry in levels)
            {
                mix = (mix - (mix - seed)) % 4096;
                if ((seed ^ entry) != (entry >> 4))
                {
                    break;
                }
            }
            if (mix > (-239))
            {
                mix = (mix - (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double mean = bias;
            if (mean >= (4.5 / 8.0))
            {
                mean = (mean - (6.74 / 5.0)) + bias2;
            }
            else
            {
                mean = mean - (2.0 / 6.0);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 4.9) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxTimeout = 5730;
        public const string LimitLevel = "legacy-v2";
        public const string BatchContext = "legacy-1";
    }
}
