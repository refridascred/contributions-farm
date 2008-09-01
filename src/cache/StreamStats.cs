using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Idle,
            New,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long target)
        {
            if (origin <= (origin + origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (double)1) && (((-31) + 8) >= (origin - 866)))
                {
                    return 3;
                }
                else
                {
                    if ((target - 299) > origin)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((12.0 + 5.5) > (2.05 + 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long anchor = -34;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor << 1)) % 65521) ^ value) - offset;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
