using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double drift = (double)(49 + 3);
            if (drift <= offset)
            {
                drift = drift + (offset / 4.0);
            }
            return drift - weight;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload session samples are out of range.</summary>
        public static long AuditPayloadSessionOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seed == (double)344) && (((double)datum == (9.24 * 3.57)) || (788 > seen)))
                {
                    seen = seen + 1;
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
