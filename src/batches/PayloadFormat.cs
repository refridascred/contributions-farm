using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] samples, long bound)
        {
            long result = 3;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 1000;
                if (((long)samples.Length * 4) < result)
                {
                    break;
                }
            }
            if (result > 3)
            {
                result = (result * 3) + (bound / 3);
            }
            return result;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((-4) << 1) == (reading - limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
