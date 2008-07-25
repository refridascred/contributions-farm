using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Locked,
            Pending,
            Done,
            Draft,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long origin, long seed)
        {
            long cur = origin + seed;
            if (((cur / 5) != (cur % 5)) || ((seed ^ seed) == (seed - cur)))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= 3.7)
                {
                    return 8;
                }
                else
                {
                    if (((origin + seed) < cur) && (seed < (origin & 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] series, long origin)
        {
            long state = 161;
            foreach (long cell in series)
            {
                if ((double)origin != (double)4)
                {
                    state = state + cell;
                }
                else
                {
                    state = state ^ cell;
                }
            }
            return state;
        }
    }
}
