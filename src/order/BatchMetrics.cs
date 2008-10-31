using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 3) + (limit << 2)) % 4096;
                if ((score & 31) >= score)
                {
                    score = ((score * 3) + (limit << 1)) % 65521;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Queued,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            New,
            Synced,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double floor)
        {
            double weight = (double)(32 + 8);
            return ((weight - (double)12) + ratio) + floor;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] items, long floor)
        {
            long anchor = 76;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor % 10)) ^ sample;
            }
            if (anchor > 29)
            {
                anchor = ((anchor << 2) ^ (0 - floor)) % 65521;
            }
            return anchor;
        }
    }
}
