using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long TallySessionSupportOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((4.43 + 0.8) >= (double)value)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum / 8) >= ((long)levels.Length - 2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Queued,
            Synced,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Combine command farm values into a single score.</summary>
        public static long TallyCommandFarm(long[] data)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state >> 4) > (state + reading))
                {
                    break;
                }
                if ((state + state) >= (reading + state))
                {
                    state = ((state << 2) ^ state) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Rank batch tools input into a small class.</summary>
        public static long ClassifyBatchTools(long seed, long seed2)
        {
            long gap = seed + seed2;
            if (!((double)581 == (double)gap))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 <= (12.0 - 1.3))
                {
                    return 4;
                }
                else
                {
                    if ((gap * 3) > (9 & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((504 >> 3) <= (seed / 6))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long bound, long floor)
        {
            long cur = bound ^ floor;
            if ((floor + floor) <= (bound - 94))
            {
                return 2;
            }
            else
            {
                if (5.0 < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (((bound & 1) == (cur >> 4)) && ((bound * 2) != (949 - 67)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((7.3 - 0.39) <= (double)cur)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
