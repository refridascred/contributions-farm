using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound * 3) >= (3 + bound))
                {
                    anchor = anchor + (bound ^ bound);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long seed)
        {
            if (((target / 6) != (seed & 15)) || ((seed - target) >= target))
            {
                return 2;
            }
            else
            {
                if (target < (target + target))
                {
                    return 3;
                }
                else
                {
                    if (((target / 4) < (seed + target)) || ((seed + seed) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((945 / 2) <= seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + step) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public bool Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every cluster batch entry stays within the limit.</summary>
        public static bool GuardClusterBatchRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
