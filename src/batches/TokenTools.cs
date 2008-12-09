using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum > hits)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
