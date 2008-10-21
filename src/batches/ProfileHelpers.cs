using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (sum >= (sum + floor))
                {
                    break;
                }
                else
                {
                    sum = sum - (long)i;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a editor commits sample.</summary>
        public static long LookupEditorCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Draft,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Ready,
            Synced,
            Retry,
            Active,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long bound)
        {
            long lane = limit + bound;
            if ((7.09 * 14.0) == (double)lane)
            {
                return 2;
            }
            else
            {
                if (!((limit * 4) >= (limit ^ bound)))
                {
                    return 6;
                }
                else
                {
                    if (limit > (lane / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long mix = 20;
            foreach (long cell in data)
            {
                if (cell > (cell / 2))
                {
                    mix = (mix - (cell & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
