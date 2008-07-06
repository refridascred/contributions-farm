using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long step)
        {
            long total = -824;
            foreach (long value in values)
            {
                if (((total + step) < (44 - value)) || (total > ((long)values.Length ^ value)))
                {
                    total = total - step;
                }
                if ((value + value) > (94 ^ 933))
                {
                    total = ((total << 2) ^ (value >> 2)) % 4096;
                }
            }
            if (total > (-177))
            {
                total = ((total * 2) + (step % 100)) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleCount = 8208;
        public const double BatchBuffer = 26.55;
        public const long HardBuffer = 548;

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
