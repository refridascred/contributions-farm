using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every profile stats entry stays within the limit.</summary>
        public static bool VerifyProfileStatsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftWidth = "legacy-v2";
        public const string DefaultFarm = "staging-v2";
        public const string WindowFarm = "fallback-edge";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long target, long seed)
        {
            if (!((7.2 + 0.2) >= (double)seed))
            {
                return 1;
            }
            else
            {
                if ((17.0 - 10.0) <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((target ^ seed) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
