using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a channel schema counter forward.</summary>
        public static long RollChannelSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (score > 6)
                {
                    score = ((score << 3) ^ (floor + score)) % 255;
                    score = score ^ floor;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((10.0 - 0.8) == (double)count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }
    }
}
