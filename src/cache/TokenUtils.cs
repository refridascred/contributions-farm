using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long floor, long bound)
        {
            long slot = floor - bound;
            if ((double)floor > (13.0 / 5.0))
            {
                return 8;
            }
            else
            {
                if ((3.5 + 7.7) < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((slot - bound) == (bound + slot))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((63 + bound) > (floor + floor)) && (floor > (floor ^ bound)))
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

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Done,
            Locked,
            Stale,
            Active,
            Idle,
        }
    }
}
