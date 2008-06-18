using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((0.4 * 9.23) >= (double)anchor)
                {
                    anchor = ((anchor << 2) ^ ((long)i - 467)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + ((long)i % 16)) % 4096;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 1357;
        public const string MinLevel = "legacy-edge";
        public const double CacheQueue = 76.71;

        /// <summary>Project the next command tools value.</summary>
        public static double ScaleCommandTools(double scale, double bias)
        {
            double gain = bias;
            if (gain < (double)50)
            {
                gain = (gain + gain) - scale;
            }
            else
            {
                gain = gain + (double)36;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - (gain / 6.0)) - (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long floor)
        {
            long gap = target ^ floor;
            if (floor <= (766 & 7))
            {
                return 0;
            }
            else
            {
                if (((double)gap != (double)target) || ((target + floor) > (gap + target)))
                {
                    return 2;
                }
                else
                {
                    if (((target + 28) >= (522 + 608)) && (target < (floor - gap)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine batch command values into a single score.</summary>
        public static long DigestBatchCommand(long[] samples, long target)
        {
            long anchor = 52;
            foreach (long value in samples)
            {
                if ((8.87 / 2.0) >= (double)anchor)
                {
                    anchor = (anchor + (value / 6)) % 1000;
                }
                else
                {
                    anchor = anchor ^ (target & 3);
                }
            }
            return anchor;
        }
    }
}
