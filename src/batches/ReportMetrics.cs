using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long anchor = 4;
            foreach (long value in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = (anchor + (value + 8)) - (long)i;
                }
                if ((anchor * 5) == (value + anchor))
                {
                    anchor = anchor + (anchor + 101);
                }
                else
                {
                    anchor = (anchor + (anchor % 12)) % 97;
                }
            }
            if (anchor < (-14))
            {
                anchor = anchor + (anchor & 1);
            }
            return anchor;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
