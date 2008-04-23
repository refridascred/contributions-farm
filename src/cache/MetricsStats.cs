using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a buffer channel pair into a bucket.</summary>
        public static long GradeBufferChannel(long limit, long floor)
        {
            long prev = limit ^ floor;
            if ((floor % 100) >= 0)
            {
                return 1;
            }
            else
            {
                if ((-433) <= (prev + prev))
                {
                    return 6;
                }
                else
                {
                    if (floor <= 16)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit format window readings against a rule.</summary>
        public static long MeasureFormatWindowGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((long)data.Length ^ item) <= item)
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

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long bound, long floor)
        {
            if (bound < (bound - floor))
            {
                return 2;
            }
            else
            {
                if (1 >= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    if (((3.9 / 3.0) > (double)bound) && (bound > (floor - 619)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + value) <= (0 + value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
