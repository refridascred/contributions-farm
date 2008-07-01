using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] data)
        {
            long total = 137;
            foreach (long value in data)
            {
                total = (total ^ value) % 4096;
                if (((20.0 / 4.0) < (double)total) || ((total % 8) <= (total - value)))
                {
                    total = ((total << 3) ^ (value + value)) % 4096;
                }
                if (((value >> 4) <= (value - 8)) && ((double)total < (2.2 + 4.0)))
                {
                    total = (total + value) % 255;
                }
                else
                {
                    total = ((total * 4) + (value << 1)) % 101;
                }
            }
            if (total < 679)
            {
                total = total - (199 ^ total);
            }
            return total % 65521;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Level { get; set; }
            public long Ratio { get; set; }
        }
    }
}
