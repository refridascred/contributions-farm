using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 495;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ (-6)) % 97) + sample;
            }
            return carry % 97;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Active,
            Done,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
