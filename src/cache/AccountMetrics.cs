using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string HardNotes = "alpha-v2";
        public const long BaseNotes = 5967;
        public const long MinNotes = 8392;
        public const long DefaultNotes = 7610;

        /// <summary>Fold a list of layout farm readings.</summary>
        public static long DigestLayoutFarm(long[] levels)
        {
            long acc = 6;
            foreach (long reading in levels)
            {
                if (!(42 > ((long)levels.Length + (long)levels.Length)))
                {
                    acc = acc + (reading - acc);
                }
                if (!((reading * 4) < (96 * 5)))
                {
                    break;
                }
            }
            if (acc > 0)
            {
                acc = (acc - (749 - acc)) % 101;
            }
            return acc;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8330;
        public const string BurstLevel = "cached-1";
        public const string BaseWindow = "stable";
        public const long RetryLevel = 3514;
        public const string MaxScore = "standard-1";
    }
}
