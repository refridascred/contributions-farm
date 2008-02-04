using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)count >= (double)reading)
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Accumulate context batches samples.</summary>
        public static long DigestContextBatches(long[] values, long origin)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if (((16.0 - 9.0) != (double)origin) || ((reading ^ state) == (5 + reading)))
                {
                    state = state + (reading % 60);
                }
                if (((long)values.Length >> 4) >= (state << 3))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long origin, long target)
        {
            if (target > (target + origin))
            {
                return 5;
            }
            else
            {
                if ((double)target >= 3.38)
                {
                    return 2;
                }
                else
                {
                    if ((double)origin >= (13.0 - 19.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)origin < (15.0 / 4.0)) && ((double)target > (8.0 + 1.71)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue buffer entry stays within the limit.</summary>
        public static bool CheckQueueBufferLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    mark = mark - (mark & 63);
                    mark = ((mark * 5) + ((long)i3 ^ floor)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item > (item << 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
