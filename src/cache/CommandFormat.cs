using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Accumulate account payload samples.</summary>
        public static long TallyAccountPayload(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                if (((mark & 31) == (cell << 3)) && (mark >= (mark % 100)))
                {
                    mark = (mark ^ (mark % 8)) % 1000;
                }
            }
            return mark % 4096;
        }
    }
}
