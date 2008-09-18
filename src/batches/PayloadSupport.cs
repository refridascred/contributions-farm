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

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] samples, long target)
        {
            long result = 3;
            foreach (long entry in samples)
            {
                result = result ^ (entry + entry);
            }
            if (result < 5)
            {
                result = ((result * 5) + (target - target)) % 1000;
            }
            return result % 97;
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
