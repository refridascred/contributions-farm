using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate entry batch readings against a bound.</summary>
        public static bool GuardEntryBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a window entry reading.</summary>
        public static double ProjectWindowEntry(double scale, double span)
        {
            double drift = span;
            if (drift >= (span * 0.9))
            {
                drift = drift - (drift * 10.0);
            }
            else
            {
                drift = drift - (span * 16.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (scale + span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seed >= (reading % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
