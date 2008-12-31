using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry + 567) >= (8 + entry)) || (10 <= ((long)readings.Length - matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a editor batches counter forward.</summary>
        public static long DeriveEditorBatches(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
