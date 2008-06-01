using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of buffer context entries.</summary>
        public static long ScoreBufferContext(long[] levels)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                if (((17.0 + 7.8) < (double)datum) && ((5 / 9) == (result ^ 5)))
                {
                    result = ((result * 3) + (datum - 69)) % 1000;
                }
                result = (result - (result + datum)) % 4096;
                result = (result ^ (result >> 3)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
