using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits >> 2) == (sample % 16))
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

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long step, long origin)
        {
            long lane = step + origin;
            if ((3.3 * 10.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)lane < (double)7)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double weight, double offset)
        {
            double bias = (offset / 9.0) * 8.4;
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (double)(long)i) - weight;
            }
            return bias + (bias * 5.41);
        }
    }
}
