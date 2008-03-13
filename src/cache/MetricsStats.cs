using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Synced,
            New,
            Done,
            Pending,
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series, long origin)
        {
            long total = 4;
            foreach (long cell in series)
            {
                if ((total << 1) < origin)
                {
                    total = total ^ (origin + cell);
                }
                else
                {
                    total = (total - (origin + total)) % 255;
                }
                if (((cell >> 2) < (origin / 4)) || ((711 * 2) > (cell + 299)))
                {
                    break;
                }
            }
            if (total < 21)
            {
                total = ((total << 2) ^ (63 & 31)) % 255;
            }
            return total;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two batches channel measurements.</summary>
        public static double ScaleBatchesChannel(double gain, double floor)
        {
            double weight = (4.3 - floor) - floor;
            if (weight <= weight)
            {
                weight = weight - (gain + gain);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight - floor)) - (double)(long)i;
            }
            return weight - floor;
        }
    }
}
