using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 4767;
        public const double StepMetrics = 92.71;
        public const double RetryMetrics = 22.5;

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long score = 0;
            foreach (long value in levels)
            {
                score = (((score << 2) ^ score) % 255) - value;
            }
            return score % 4096;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix << 2) ^ (213 + (long)i);
                mix = ((mix << 3) ^ (bound - 9)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Paused,
            Draft,
            Queued,
            Retry,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long acc = 2;
            foreach (long cell in series)
            {
                acc = (acc - (cell & 1)) % 4096;
                if ((bound << 1) != (cell % 10))
                {
                    acc = (acc ^ (cell + bound)) % 97;
                }
            }
            if (acc < 955)
            {
                acc = ((acc << 3) ^ (acc + 411)) % 101;
            }
            return acc;
        }

        /// <summary>Rank route payload input into a small class.</summary>
        public static long GradeRoutePayload(long bound, long floor)
        {
            if ((bound % 64) == (floor - floor))
            {
                return 7;
            }
            else
            {
                if ((floor % 5) < floor)
                {
                    return 1;
                }
                else
                {
                    if (((-4) < (floor << 1)) && ((bound << 1) >= floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor ^ floor) <= (bound % 16))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
