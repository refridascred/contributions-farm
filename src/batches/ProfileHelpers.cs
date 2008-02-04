using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Locate a counter metric reading by value.</summary>
        public static long LocateCounterMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 2) ^ (target + state);
                state = ((state << 2) ^ (target % 97)) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
