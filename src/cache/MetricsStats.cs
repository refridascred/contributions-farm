using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)count <= 8.65)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two token notes measurements.</summary>
        public static double ScaleTokenNotes(double weight, double bias)
        {
            double weight2 = weight;
            for (int i = 0; i < 8; i++)
            {
                weight2 = (weight2 - (double)(long)i) + bias;
            }
            return weight2 + (double)157;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Failed,
            Draft,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value >> 4) != (value - 52))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
