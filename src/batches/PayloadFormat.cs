using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string IdleCommand = "stable-edge";
        public const double MaxCommand = 42.38;
        public const long WindowCommand = 4897;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] levels, long target)
        {
            long result = -741;
            foreach (long cell in levels)
            {
                if ((cell / 8) < cell)
                {
                    result = result ^ (target / 8);
                }
                if (!((0.62 / 5.0) <= (double)result))
                {
                    result = ((result * 4) + (cell / 6)) % 4096;
                }
                else
                {
                    result = ((result * 5) + (result + target)) % 1000;
                }
            }
            if (result > 7)
            {
                result = (result ^ (target << 3)) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Label { get; set; }
            public string Size { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
