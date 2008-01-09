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

        /// <summary>Combine graph payload values into a single score.</summary>
        public static long TotalGraphPayload(long[] series)
        {
            long total = 520;
            foreach (long reading in series)
            {
                if (!((9 ^ total) > reading))
                {
                    total = ((total << 3) ^ (reading << 3)) % 1000;
                    continue;
                }
                if ((reading + 1) <= (total / 6))
                {
                    total = total + total;
                }
            }
            return total;
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
