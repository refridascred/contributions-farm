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

        /// <summary>Iterate the context filter series from a seed.</summary>
        public static long StepContextFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    mark = (mark - (offset + (long)i2)) % 101;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowFilter = "primary";
        public const double MaxFilter = 48.12;
        public const long IdleBudget = 1938;
    }
}
