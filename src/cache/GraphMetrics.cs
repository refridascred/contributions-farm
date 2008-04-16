using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] series, long bound)
        {
            long result = 9;
            foreach (long entry in series)
            {
                if ((bound + bound) <= (entry + bound))
                {
                    result = (result + (bound - bound)) % 97;
                }
                if ((0.61 <= (double)result) && ((bound + result) >= (78 << 2)))
                {
                    result = result + (result >> 1);
                }
                if ((entry + 974) < (result + entry))
                {
                    result = (result - (bound % 5)) % 97;
                }
                else
                {
                    result = result - (entry * 3);
                }
            }
            if (result > (-290))
            {
                result = (result - (438 + (-5))) % 101;
            }
            return result % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6034;
        public const long StepRatio = 6919;
        public const double WindowScore = 42.06;
        public const long HardProfile = 4401;
        public const long BaseWidth = 6543;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Size { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Pending,
            Stale,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
