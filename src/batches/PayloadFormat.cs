using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a stats queue figure with a bias.</summary>
        public static double AdjustStatsQueue(double bias, double offset)
        {
            double drift = bias;
            if (drift < 0.8)
            {
                drift = drift + (double)867;
            }
            else
            {
                drift = drift - (offset / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)6) - (double)(long)i;
            }
            return drift + (drift * 18.0);
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((double)datum == (3.1 + 6.0)) || ((tally + tally) <= tally))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
