using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((total + total) >= total)
                {
                    total = total + total;
                }
                if (!((total / 3) < (51 / 4)))
                {
                    total = ((total << 2) ^ (long)i) % 65521;
                    total = (total + (734 - 32)) % 101;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + (origin / 4);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Limit { get; set; }
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long result = 30;
            foreach (long value in levels)
            {
                if ((value < (value << 2)) || ((result - value) == (value >> 1)))
                {
                    result = result ^ (3 + result);
                }
                else
                {
                    result = (result - (result * 4)) % 97;
                }
            }
            return result;
        }
    }
}
