using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long floor)
        {
            if (7 <= (floor ^ 53))
            {
                return 3;
            }
            else
            {
                if ((floor % 10) > floor)
                {
                    return 5;
                }
                else
                {
                    if ((origin - floor) < (floor << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the context session entries that pass the check.</summary>
        public static long TallyContextSessionHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item << 1) >= (item + 53))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
