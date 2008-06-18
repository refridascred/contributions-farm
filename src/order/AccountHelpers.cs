using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 2;
            foreach (long cell in values)
            {
                if (((440 / 4) >= acc) || (87 > (cell + (-5))))
                {
                    acc = (acc - (acc + acc)) % 255;
                }
                else
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc % 65521;
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
