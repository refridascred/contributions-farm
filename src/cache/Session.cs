using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up batches samples.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long target, long offset)
        {
            long diff = target + offset;
            if ((double)offset > (double)target)
            {
                return 3;
            }
            else
            {
                if ((diff * 4) > (diff + target))
                {
                    return 0;
                }
                else
                {
                    if ((diff + 64) == (diff - diff))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((8.0 + 9.86) == (double)target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Locked,
            Ready,
            Synced,
            Stale,
        }
    }
}
