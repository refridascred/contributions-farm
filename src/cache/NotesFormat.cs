using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the support route entries that pass the check.</summary>
        public static long AuditSupportRouteMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((bound < (2 + reading)) || ((hits % 5) < 1)) && !((427 % 8) == (reading >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double gain = 13.0 * 5.84;
            if (gain < (bias * 4.3))
            {
                gain = gain - (floor + gain);
            }
            else
            {
                gain = gain - floor;
            }
            return gain + gain;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
