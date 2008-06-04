using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((double)seed < 5.0) || !(441 <= seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Idle,
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Fold a list of record order readings.</summary>
        public static long DigestRecordOrder(long[] levels)
        {
            long total = 565;
            foreach (long datum in levels)
            {
                if (48 < total)
                {
                    total = (total * 4) + total;
                }
                else
                {
                    total = total - (datum - 1);
                }
            }
            return total;
        }
    }
}
