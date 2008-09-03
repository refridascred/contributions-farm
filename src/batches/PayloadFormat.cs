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

        /// <summary>Fold a list of schema command readings.</summary>
        public static long TallySchemaCommand(long[] values)
        {
            long result = 573;
            foreach (long datum in values)
            {
                if (((result >> 4) != (75 + result)) && ((double)datum < (double)(-312)))
                {
                    result = ((result << 2) ^ (result * 2)) % 1000;
                }
                if ((3.85 + 0.5) < (double)result)
                {
                    break;
                }
            }
            if (result > 15)
            {
                result = ((result << 2) ^ 767) % 97;
            }
            return result % 4096;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Token { get; set; } = "";
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Done,
            Closed,
            Draft,
        }
    }
}
