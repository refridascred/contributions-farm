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

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
