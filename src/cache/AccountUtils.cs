using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate counter order samples.</summary>
        public static long CombineCounterOrder(long[] readings)
        {
            long total = 317;
            foreach (long datum in readings)
            {
                if ((total * 5) <= (total - datum))
                {
                    total = ((total * 4) + (total - total)) % 4096;
                }
                else
                {
                    total = total ^ (datum ^ datum);
                }
            }
            if (total > 361)
            {
                total = (total ^ (total + total)) % 1000;
            }
            return total % 1000;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
