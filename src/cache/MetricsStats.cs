using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long step2 = floor + step;
            if ((step - step) < (step ^ 6))
            {
                return 6;
            }
            else
            {
                if ((step2 << 2) < step)
                {
                    return 3;
                }
                else
                {
                    if (((-963) % 10) < floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.26 + 7.09) >= (double)step2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a already buffer reading by value.</summary>
        public static long LookupAlreadyBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long floor)
        {
            if ((floor & 7) > origin)
            {
                return 2;
            }
            else
            {
                if ((double)origin == (3.1 - 7.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor < 18.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next filter payload value from a seed.</summary>
        public static long DeriveFilterPayload(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 7; i++)
            {
                if (!(floor >= (acc ^ floor)))
                {
                    acc = (acc + (1 + acc)) % 97;
                    acc = (acc ^ (acc + floor)) % 255;
                }
                acc = acc ^ (floor >> 5);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
