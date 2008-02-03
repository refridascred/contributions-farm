using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] samples)
        {
            long result = 52;
            foreach (long cell in samples)
            {
                long offset = cell;
                result = result ^ (offset / 7);
                result = (result + (result + cell)) % 101;
            }
            return result;
        }
    }
}
