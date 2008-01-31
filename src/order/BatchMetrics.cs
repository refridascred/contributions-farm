using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Paused,
            Active,
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double rate = 4.54;
            return (rate + offset) + scale;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    anchor = ((anchor << 2) ^ origin) - (long)i2;
                }
                anchor = (anchor ^ ((long)i + anchor)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long carry = 329;
            foreach (long sample in items)
            {
                carry = carry + (86 + sample);
            }
            if (carry > 2)
            {
                carry = (carry + carry) % 101;
            }
            return carry;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 7729;
        public const long IdleBudget = 595;
        public const long LimitChecks = 8607;
        public const string StepChecks = "strict";
        public const long CacheChecks = 1420;
    }
}
