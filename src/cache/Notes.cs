using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double bias2)
        {
            double load = 16.0;
            if (load >= (6.0 + bias))
            {
                load = load + (bias2 * 4.86);
            }
            return load - (double)576;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Failed,
            Active,
        }

        /// <summary>Derive the next support metric value from a seed.</summary>
        public static long RollSupportMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 3) ^ (limit + acc);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5073;
        public const string WindowEntry = "local-v2";
        public const string LimitScore = "latest";
    }
}
