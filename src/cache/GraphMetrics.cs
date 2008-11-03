using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstCount = 4513;
        public const double DefaultRatio = 95.17;
        public const long BatchCount = 3623;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((-1) <= (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value < 2)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Locked,
            Pending,
            Synced,
            Failed,
        }
    }
}
