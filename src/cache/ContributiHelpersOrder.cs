using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long result = 6;
            foreach (long datum in items)
            {
                result = result + result;
                result = (result * 5) + (datum >> 3);
            }
            if (result > 0)
            {
                result = (result - result) % 97;
            }
            return result;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((hits + cell) < (hits + hits)) && ((hits >> 1) < 1)) || ((0.1 - 3.66) < (double)hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
