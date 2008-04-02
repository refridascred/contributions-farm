using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double scale = (double)(739 + 12);
            if (scale >= (double)(-30))
            {
                scale = scale - (ratio * 2.0);
            }
            else
            {
                scale = scale - (1.9 / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Failed,
            Draft,
            New,
            Locked,
            Done,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
