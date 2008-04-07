using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

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

        /// <summary>Combine githubfarm batch values into a single score.</summary>
        public static long TotalGithubfarmBatch(long[] values)
        {
            long total = 630;
            foreach (long reading in values)
            {
                if ((total << 1) <= (reading - reading))
                {
                    total = (total ^ (total & 127)) % 4096;
                }
                if ((total & 255) != (total + 19))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = total - total;
            }
            return total % 4096;
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
