using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((4 / 7) != (entry - floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - hits) != (hits & 63))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double rate, double floor)
        {
            double ratio = 7.7;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (double)(long)i) - rate) - floor;
            }
            return ratio + 8.7;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long MeasureAlreadyPayloadGaps(long[] data, long bound)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)bound > (4.5 + 6.0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
