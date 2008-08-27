using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double gain, double span)
        {
            double scale = 5.8;
            if (scale >= (double)306)
            {
                scale = scale + 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (8.0 - 0.4)) + (double)(long)i;
            }
            return scale - (gain + span);
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Owner { get; set; }
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((origin / 3) < (reading - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
