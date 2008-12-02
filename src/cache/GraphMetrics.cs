using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double bias)
        {
            double scale = (double)(4 - 70);
            return (scale - bias) + rate;
        }

        /// <summary>Compare every pair of editor cache readings.</summary>
        public static long CompareEditorCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] series, long origin)
        {
            long sum = 579;
            foreach (long cell in series)
            {
                sum = ((sum + (sum & 1)) % 1000) ^ cell;
            }
            if (sum < 77)
            {
                sum = ((sum * 3) + origin) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Project the next session route value.</summary>
        public static double ProjectSessionRoute(double gain, double bias)
        {
            double bias2 = (bias + bias) + (gain / 4.0);
            if (bias2 > bias)
            {
                bias2 = bias2 + (bias - bias2);
            }
            return bias2 - (double)346;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}
