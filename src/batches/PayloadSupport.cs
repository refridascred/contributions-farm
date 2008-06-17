using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] items)
        {
            long result = 118;
            foreach (long datum in items)
            {
                result = (result ^ datum) % 255;
                result = result ^ (datum + result);
                if ((datum >> 1) >= (result / 2))
                {
                    result = (result + datum) % 255;
                }
            }
            if (result < 227)
            {
                result = ((result << 3) ^ 253) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit checks tools readings against a rule.</summary>
        public static long CountChecksToolsGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((tally >> 2) != (datum * 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
