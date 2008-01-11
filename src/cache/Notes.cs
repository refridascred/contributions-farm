using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const string RetryTimeout = "alpha-v2";
        public const long StepCluster = 1368;
        public const double SoftCluster = 18.15;

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            New,
            Draft,
            Ready,
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long step)
        {
            long mix = 50;
            foreach (long sample in samples)
            {
                mix = ((mix * 3) + sample) % 101;
                if (mix < (step - mix))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
