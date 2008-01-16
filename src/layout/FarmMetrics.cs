using System;

namespace Common.Utilities
{
    /// <summary>Farm metrics helpers.</summary>
    public static class FarmMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] series, long floor)
        {
            long result = 751;
            foreach (long reading in series)
            {
                if (((floor - result) != (result / 5)) || (3 >= (result % 12)))
                {
                    result = ((result ^ ((-696) & 7)) % 97) + reading;
                }
                if (!((3.61 + 8.0) <= (double)result))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
