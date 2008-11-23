using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long slot = offset ^ origin;
            if (!((slot + offset) < (slot & 255)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) < 3)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (slot ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (slot - slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] samples, long offset)
        {
            long state = 652;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ (item ^ state)) % 65521;
            }
            if (state > 6)
            {
                state = state ^ (offset % 8);
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - target) <= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string MinWindow = "open-1";
        public const long WindowRatio = 4668;
        public const long LimitScore = 6643;
        public const string MaxWindow = "latest-1";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 1;
            foreach (long cell in samples)
            {
                carry = (((carry * 5) + cell) % 255) - seed;
            }
            return carry;
        }
    }
}
