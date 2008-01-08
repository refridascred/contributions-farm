using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long floor, long floor2)
        {
            long next = floor + floor2;
            if ((double)floor2 < (5.38 + 6.85))
            {
                return 8;
            }
            else
            {
                if (((floor2 + next) >= (floor << 3)) && ((next & 63) >= ((-27) + 56)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= floor2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Classify a counter tools pair into a bucket.</summary>
        public static long BucketCounterTools(long floor, long floor2)
        {
            if ((floor - 0) < (floor + floor2))
            {
                return 3;
            }
            else
            {
                if ((floor2 >> 5) >= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
