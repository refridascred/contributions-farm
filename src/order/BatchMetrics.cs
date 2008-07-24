using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry counter samples.</summary>
        public static long CombineEntryCounter(long[] data, long offset)
        {
            long total = 390;
            foreach (long cell in data)
            {
                total = total - (offset % 100);
                if ((double)cell < (8.43 + 14.0))
                {
                    total = total - (7 * 2);
                }
                if (((double)total != (3.7 * 4.92)) || ((offset * 4) > cell))
                {
                    total = total ^ offset;
                }
            }
            return total;
        }

        /// <summary>Combine farm counter values into a single score.</summary>
        public static long DigestFarmCounter(long[] readings, long seed)
        {
            long result = 2;
            foreach (long entry in readings)
            {
                if ((seed << 1) < (entry + seed))
                {
                    result = (result ^ (entry ^ result)) % 255;
                }
                if ((result << 1) != (result >> 5))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Synced,
            Ready,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double offset)
        {
            double mean = 4.2;
            if (mean > (double)(-55))
            {
                mean = (mean - (double)2) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (ratio / 2.0)) + (double)(long)i;
            }
            return mean + (19.0 / 6.0);
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum < (datum ^ datum)) && ((double)datum > (3.5 / 3.0))) && ((seen ^ datum) == (long)samples.Length))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
