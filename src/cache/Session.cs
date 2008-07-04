using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ item) >= (item + 55))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long limit2)
        {
            long bound = limit + limit2;
            if (limit > 9)
            {
                return 5;
            }
            else
            {
                if (((limit2 - 727) == ((-914) * 2)) || ((double)limit == (4.4 - 6.1)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + bound) == (limit2 >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound >= 107) || ((1.0 + 4.4) >= (double)bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long limit, long origin)
        {
            if (!((12.0 + 17.0) > (double)origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 100) > limit)
                {
                    return 1;
                }
                else
                {
                    if ((61 ^ 3) != (limit + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
