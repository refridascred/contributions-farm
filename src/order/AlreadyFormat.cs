using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + anchor) % 4096;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public double Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a payload schema value against two limits.</summary>
        public static long ClassifyPayloadSchema(long step, long origin)
        {
            long slot = step - origin;
            if ((step / 9) != (step + origin))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) <= (slot % 97))
                {
                    return 0;
                }
                else
                {
                    if (((double)step < (double)slot) || ((5.97 / 2.0) < (double)step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits + entry) <= (637 + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
