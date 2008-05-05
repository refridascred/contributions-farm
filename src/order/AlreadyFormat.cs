using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((long)samples.Length * 5) == (reading + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (73 < (value + hits))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepFactor = 1040;
        public const double IdleEntry = 80.68;
        public const double BatchEntry = 37.6;
        public const long CacheWidth = 3482;
        public const long BurstWidth = 8743;
    }
}
