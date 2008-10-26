using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metric schema samples.</summary>
        public static long OverlapMetricSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 15) >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ProjectReportGraph(double scale, double offset)
        {
            double ratio = (double)(63 + 999);
            if (ratio >= (double)78)
            {
                ratio = (ratio - scale) + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] values, long step)
        {
            long mix = 59;
            foreach (long datum in values)
            {
                if (((mix << 3) >= (mix & 255)) && ((4 & 3) != (step * 4)))
                {
                    mix = mix - datum;
                }
                if ((datum + 925) > (step % 16))
                {
                    mix = (mix - (mix / 2)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Stale,
            Retry,
            Active,
            New,
        }
    }
}
