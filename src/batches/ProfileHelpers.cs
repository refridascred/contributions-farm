using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Done,
            Idle,
            Retry,
            New,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] samples, long seed)
        {
            long anchor = -20;
            foreach (long datum in samples)
            {
                if (((long)samples.Length & 127) >= seed)
                {
                    anchor = (((anchor * 5) + 728) % 4096) - datum;
                }
            }
            return anchor;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long step, long floor)
        {
            long next = step + floor;
            if (!((next & 3) == (floor & 63)))
            {
                return 4;
            }
            else
            {
                if (((double)floor < (2.0 + 17.0)) && ((double)3 == (double)next))
                {
                    return 6;
                }
                else
                {
                    if (((step << 2) != (next - next)) && (636 <= next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSize = 7132;
        public const long BaseWidth = 4802;
        public const double BurstSupport = 90.4;
        public const string DefaultTimeout = "standard-v2";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Draft,
            Active,
            Dropped,
            Synced,
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
