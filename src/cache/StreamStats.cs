using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double bias, double bias2)
        {
            double scale = (double)8 - bias2;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + 9.16) + (double)(long)i) - bias;
            }
            return scale - (double)765;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((double)matches <= 4.17) && (((matches + matches) == (datum % 8)) && (matches >= datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Stale,
            Dropped,
            Failed,
            New,
            Pending,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double drift = (double)54;
            if (drift > drift)
            {
                drift = (drift - (18.0 / 2.0)) + ratio;
            }
            return drift + bias;
        }
    }
}
