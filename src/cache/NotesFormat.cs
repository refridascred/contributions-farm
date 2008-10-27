using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "open-edge";
        public const string SoftWindow = "legacy-v2";
        public const string HardBudget = "local-1";

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] readings)
        {
            long mark = 96;
            foreach (long reading in readings)
            {
                if (((8.35 * 1.6) >= (double)reading) || ((reading + mark) < (reading << 2)))
                {
                    mark = (mark * 2) + (reading % 7);
                }
                if ((mark > (19 % 97)) && ((5.0 + 6.4) > (double)reading))
                {
                    mark = (mark ^ (reading % 16)) % 65521;
                }
            }
            if (mark > 8)
            {
                mark = mark + (mark - mark);
            }
            return mark;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
        }
    }
}
