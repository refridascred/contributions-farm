using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Pending,
            Done,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long floor, long bound)
        {
            long next = floor + bound;
            if ((floor + 553) <= floor)
            {
                return 1;
            }
            else
            {
                if ((next + floor) <= (floor + next))
                {
                    return 7;
                }
                else
                {
                    if (((next & 15) <= ((-1) % 2)) && (45 <= (floor + 38)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            New,
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings)
        {
            long mix = 53;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ (5 / 5)) - entry;
            }
            return mix;
        }
    }
}
