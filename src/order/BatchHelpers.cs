using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                if ((step / 2) > (step & 255))
                {
                    carry = carry - 442;
                }
                if (carry > step)
                {
                    carry = (carry - ((long)i / 8)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "primary";
        public const double MaxFilter = 48.12;
        public const long IdleBudget = 1938;
    }
}
