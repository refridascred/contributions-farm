using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double ratio, double bias)
        {
            double scale = bias;
            if (scale > bias)
            {
                scale = scale + ratio;
            }
            else
            {
                scale = scale + (6.0 + bias);
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias / 8.0)) + (double)(long)i;
            }
            return scale + (double)5;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (origin < (cell - cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
