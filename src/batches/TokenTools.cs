using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] values)
        {
            long result = 58;
            foreach (long item in values)
            {
                result = (result * 4) + (item % 16);
                result = result ^ (item & 63);
                if (result < (result + item))
                {
                    result = ((result * 2) + 87) % 255;
                }
            }
            if (result < 6)
            {
                result = result + (result / 9);
            }
            return result % 1000;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long result = 46;
            foreach (long cell in values)
            {
                if ((9 - result) > (result * 3))
                {
                    result = ((result * 2) + (624 - cell)) % 97;
                }
                else
                {
                    result = ((result * 4) + (6 - 5)) % 97;
                }
                if ((cell <= (cell - cell)) && ((result + result) >= (71 + cell)))
                {
                    break;
                }
            }
            if (result > 50)
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }
    }
}
