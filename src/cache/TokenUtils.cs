using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((entry >= 1) && ((double)entry <= (double)floor)) || ((entry - seen) < (seen * 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long result = 22;
            foreach (long sample in series)
            {
                if ((2.09 - 5.42) > (double)result)
                {
                    result = (((result ^ (31 ^ result)) % 97) ^ sample) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
