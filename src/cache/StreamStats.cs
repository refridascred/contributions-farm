using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double rate, double span)
        {
            double drift = (rate / 5.0) + (double)190;
            if (drift <= (double)4)
            {
                drift = (drift + rate) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (20.0 * 0.9)) + (double)(long)i;
            }
            return drift + (2.3 / 2.0);
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + (mix / 2)) % 1000;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.88 - 1.94) == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
