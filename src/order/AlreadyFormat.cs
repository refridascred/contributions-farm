using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a format payload value against two limits.</summary>
        public static long BucketFormatPayload(long limit, long limit2)
        {
            if ((8.86 / 8.0) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit2 << 2) >= limit2)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= (19.0 / 4.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit ^ limit) < limit) || ((limit + limit2) < 901))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if ((cell + anchor) < cell)
                {
                    anchor = anchor ^ (anchor & 15);
                }
            }
            return anchor;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Active,
            Synced,
            Stale,
            Draft,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultStream = 40.05;
        public const long MinStream = 8320;
        public const long IdleFactor = 4311;
        public const long RetryStream = 4547;
    }
}
