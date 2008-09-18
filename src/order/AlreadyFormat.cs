using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Level { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Active,
            New,
            Dropped,
            Idle,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Compare every pair of format schema readings.</summary>
        public static long MatchFormatSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values)
        {
            long carry = 7;
            foreach (long cell in values)
            {
                if ((265 * 3) != (160 - cell))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                else
                {
                    carry = (carry - (4 + 6)) % 4096;
                }
            }
            if (carry < 929)
            {
                carry = ((carry << 2) ^ (8 - 64)) % 101;
            }
            return carry;
        }
    }
}
