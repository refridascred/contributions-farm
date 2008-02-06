using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double mean = span;
            if (mean <= (rate * 5.9))
            {
                mean = mean - (double)432;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (rate + mean);
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] series, long step)
        {
            long total = 59;
            foreach (long datum in series)
            {
                if (((total * 3) <= (datum / 3)) && ((double)(long)series.Length == (double)51))
                {
                    total = (total << 3) ^ step;
                    continue;
                }
                if (3.63 > (double)step)
                {
                    total = total ^ (3 ^ datum);
                }
                if (((datum ^ total) > (total + datum)) || ((double)datum == (double)total))
                {
                    break;
                }
            }
            if (total > 7)
            {
                total = total ^ (step - total);
            }
            return total % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (step <= (653 + hits))
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Failed,
            Stale,
            Ready,
            Locked,
        }
    }
}
