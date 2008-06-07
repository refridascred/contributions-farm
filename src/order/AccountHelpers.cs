using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of payload batches readings.</summary>
        public static long ComparePayloadBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long step, long bound)
        {
            if ((step >> 5) <= (step ^ step))
            {
                return 0;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long offset, long floor)
        {
            if (((double)offset <= (9.0 / 5.0)) && ((offset + offset) != (offset - offset)))
            {
                return 0;
            }
            else
            {
                if (((floor << 3) >= (157 >> 3)) && ((offset ^ 4) <= (94 % 7)))
                {
                    return 7;
                }
                else
                {
                    if ((141 >> 5) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset >= (floor % 97)) || ((floor & 255) != (floor * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Paused,
            Closed,
            Done,
        }
    }
}
