using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long seed)
        {
            if (33 >= (target / 7))
            {
                return 6;
            }
            else
            {
                if ((8 / 2) > (seed * 5))
                {
                    return 4;
                }
                else
                {
                    if ((108 % 60) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((target + 679) != (seed ^ seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((reading + reading) == (reading * 3)))
                {
                    count = (count + 2) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((double)floor >= (0.3 - 4.2)))
                {
                    tally = (tally + 3) ^ reading;
                }
            }
            return tally;
        }
    }
}
