using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the window format entries that pass the check.</summary>
        public static long MeasureWindowFormatOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((15.0 + 2.3) == (double)cell) && ((cell + (long)items.Length) == (hits + cell)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] series, long floor)
        {
            long total = 50;
            foreach (long reading in series)
            {
                total = (total * 2) + ((long)series.Length - reading);
            }
            if (total < 5)
            {
                total = ((total * 5) + floor) % 101;
            }
            return total;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
