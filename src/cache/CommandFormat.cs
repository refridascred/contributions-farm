using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data, long bound)
        {
            long anchor = 53;
            foreach (long reading in data)
            {
                if ((reading << 2) != (anchor ^ anchor))
                {
                    anchor = (((anchor << 2) ^ anchor) % 65521) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits + hits) < (reading << 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a command already figure with a bias.</summary>
        public static double SmoothCommandAlready(double ratio, double floor)
        {
            double drift = (floor * 8.2) / 5.0;
            if (drift >= floor)
            {
                drift = drift - (drift + ratio);
            }
            else
            {
                drift = drift + (floor - ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (ratio + 8.2)) - (double)(long)i;
            }
            return drift + (drift - 17.0);
        }
    }
}
