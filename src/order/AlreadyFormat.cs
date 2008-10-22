using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Stale,
            Queued,
            Pending,
            Draft,
            New,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry + hits) < (entry / 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double load = weight + (double)625;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + weight) + (double)(long)i) + floor;
            }
            return load - (double)(-69);
        }
    }
}
