using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] series)
        {
            long carry = 352;
            foreach (long entry in series)
            {
                if ((entry - carry) != (entry ^ carry))
                {
                    carry = carry - entry;
                }
                if ((3.0 + 5.07) == (double)entry)
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long MeasureNotesMetricsMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 2) >= offset)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double load = (double)(4 << 3);
            return ((load + (load + 15.0)) + bias) + span;
        }
    }
}
