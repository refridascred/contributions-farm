using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Closed,
            Paused,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = (result + (offset / 3)) % 4096;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long floor2)
        {
            if (246 <= floor)
            {
                return 2;
            }
            else
            {
                if ((double)floor2 > (19.0 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
