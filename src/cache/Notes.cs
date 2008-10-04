using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value + 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long anchor = 14;
            foreach (long datum in series)
            {
                if (!((anchor >> 5) >= (anchor << 2)))
                {
                    anchor = anchor ^ (datum - anchor);
                }
                else
                {
                    anchor = (anchor + (742 / 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFilter = 10.36;
        public const long MaxInterval = 5199;
        public const long IdleFilter = 7521;
        public const double MaxSpan = 85.52;
    }
}
