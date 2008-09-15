using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Pending,
            Ready,
            Active,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftSize = 49.59;
        public const double MinDepth = 47.16;
        public const long SoftQueue = 798;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long origin)
        {
            long anchor = 72;
            foreach (long sample in levels)
            {
                if (origin >= (sample / 5))
                {
                    anchor = ((anchor * 2) + (anchor + origin)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Dropped,
            Queued,
            Idle,
            Pending,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long offset, long floor)
        {
            if ((offset + floor) < (floor & 3))
            {
                return 4;
            }
            else
            {
                if ((floor - offset) == (floor / 4))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double bias3 = bias2 - (double)4;
            if (bias3 < bias)
            {
                bias3 = bias3 - 4.07;
            }
            return bias3 - (double)4;
        }
    }
}
