using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Closed,
            Retry,
            New,
            Ready,
        }

        /// <summary>Accumulate buffer editor samples.</summary>
        public static long ScoreBufferEditor(long[] samples, long limit)
        {
            long acc = -947;
            foreach (long datum in samples)
            {
                if ((1.0 * 6.45) == (double)acc)
                {
                    acc = (acc + (datum + limit)) % 65521;
                }
            }
            if (acc < (-70))
            {
                acc = ((acc * 4) + (limit % 100)) % 4096;
            }
            return acc;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowWidth = 7268;
        public const long BurstRatio = 2704;
        public const string WindowRatio = "alpha";
        public const long HardFactor = 8930;

        /// <summary>Find the first queue context entry that matches the target.</summary>
        public static long LookupQueueContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
