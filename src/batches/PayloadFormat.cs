using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the commits stream series from a seed.</summary>
        public static long IterateCommitsStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor - (long)i2) % 1000;
                    anchor = (anchor * 3) + 9;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many stream window samples are out of range.</summary>
        public static long MeasureStreamWindowHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((177 + step) > (sample * 5))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(((long)readings.Length - 3) >= item))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
