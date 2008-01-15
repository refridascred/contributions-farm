using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((double)total >= 0.4) || ((bound << 2) >= (bound << 3)))
                {
                    break;
                }
                else
                {
                    total = (total ^ (17 + total)) % 255;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((7.5 / 8.0) < (double)hits) && (hits >= (hits % 7)))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double weight2 = (span * 4.6) / 6.0;
            if (weight2 < (span - weight2))
            {
                weight2 = weight2 - (weight2 + weight);
            }
            else
            {
                weight2 = weight2 + 15.0;
            }
            return weight2 - 12.0;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (limit / 4)) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
