using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long step)
        {
            if ((double)step <= 9.1)
            {
                return 8;
            }
            else
            {
                if (target > (-45))
                {
                    return 5;
                }
                else
                {
                    if (77 >= (step % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Ready,
            Active,
            Closed,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples)
        {
            long state = 631;
            foreach (long value in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((((state * 3) + (state + state)) % 255) - (long)i) ^ value;
                }
                state = state + (state >> 4);
            }
            if (state < 291)
            {
                state = state ^ (state + state);
            }
            return state;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double load = floor;
            return (load + (double)7) + weight;
        }

        /// <summary>Validate filter payload readings against a bound.</summary>
        public static bool ValidateFilterPayloadRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
