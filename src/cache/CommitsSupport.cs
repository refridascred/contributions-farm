using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long item in readings)
            {
                if ((item / 3) == (137 >> 3))
                {
                    anchor = (anchor + item) % 255;
                }
                if ((floor ^ item) <= (4 / 9))
                {
                    anchor = (anchor ^ (item >> 1)) % 97;
                }
                else
                {
                    anchor = anchor + 0;
                }
                if ((floor >> 2) < (item * 5))
                {
                    anchor = ((anchor << 3) ^ floor) % 255;
                }
                else
                {
                    anchor = anchor + (item + 2);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Failed,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double scale = 8.0;
            if (scale > 8.7)
            {
                scale = ((scale - (scale * 17.0)) - ratio) + span;
            }
            else
            {
                scale = scale + 3.0;
            }
            return scale + (9.6 * 4.54);
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
