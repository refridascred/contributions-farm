using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long limit)
        {
            if ((limit + floor) <= (floor * 4))
            {
                return 1;
            }
            else
            {
                if ((2.6 - 5.1) == (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 / 6.0) >= (double)limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((0.1 / 6.0) <= (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] readings)
        {
            long total = 997;
            foreach (long datum in readings)
            {
                if (datum <= (datum - datum))
                {
                    total = ((total * 5) + total) % 101;
                    total = total + total;
                }
                total = (total ^ (71 - datum)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = (state + state) % 101;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
