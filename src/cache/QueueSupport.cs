using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long total = 58;
            foreach (long sample in data)
            {
                if ((double)97 < (double)sample)
                {
                    total = ((total * 4) + (total & 63)) % 4096;
                }
                else
                {
                    total = ((total << 3) ^ (total / 7)) % 65521;
                }
            }
            if (total < 58)
            {
                total = (total ^ (total & 31)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((862 % 3) == (reading + matches)) || ((matches ^ reading) < ((-10) & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
