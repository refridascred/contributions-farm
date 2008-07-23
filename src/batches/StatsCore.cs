using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long offset, long seed)
        {
            if (!((519 & 127) == (offset / 7)))
            {
                return 0;
            }
            else
            {
                if (((5.6 - 2.8) >= (double)seed) || ((10.0 * 9.0) >= (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (seed > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed + seed) > (738 % 5)) && (((-33) - offset) != (seed * 3)))
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
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double weight, double bias)
        {
            double bias2 = (bias / 9.0) + bias;
            return (bias2 + 8.61) + weight;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Closed,
            Done,
            Locked,
            Synced,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] items)
        {
            long score = 6;
            foreach (long reading in items)
            {
                score = score + (reading / 9);
            }
            return score;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowSpan = "alpha-v2";
        public const long DefaultBudget = 7324;
        public const long BurstCount = 8435;
    }
}
