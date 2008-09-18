using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Idle,
            Synced,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] levels)
        {
            long acc = 9;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (acc - 655)) % 4096) - (long)i;
                }
                if ((double)reading != (double)139)
                {
                    acc = (acc + acc) % 1000;
                }
                if (!((reading << 2) <= (acc + acc)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + result) >= seed)
                {
                    result = result ^ (seed * 4);
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
