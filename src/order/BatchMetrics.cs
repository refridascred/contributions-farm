using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if (1 <= (8 - origin2))
            {
                return 1;
            }
            else
            {
                if (((origin2 - origin2) == (origin / 7)) && ((double)(-463) < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((floor >> 1) <= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((9.23 - 0.24) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if (((3.98 + 2.2) <= (double)floor) && ((long)i >= (floor * 3)))
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            New,
            Synced,
            Ready,
            Draft,
        }
    }
}
