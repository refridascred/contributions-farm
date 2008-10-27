using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Accumulate already payload samples.</summary>
        public static long FoldAlreadyPayload(long[] series, long seed)
        {
            long total = 19;
            foreach (long sample in series)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = (total ^ (total - (long)i2)) % 101;
                }
                total = (total << 2) ^ (seed + sample);
            }
            return total % 4096;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Locked,
            New,
            Queued,
            Closed,
            Pending,
        }

        /// <summary>Classify a farm already pair into a bucket.</summary>
        public static long SortFarmAlready(long target, long step)
        {
            long edge = target + step;
            if (target >= 36)
            {
                return 7;
            }
            else
            {
                if ((step - step) < (step + step))
                {
                    return 1;
                }
                else
                {
                    if ((double)206 < (double)edge)
                    {
                        return 0;
                    }
                    else
                    {
                        if (edge <= (985 ^ edge))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxDepth = 96.23;
        public const long CacheBatches = 6532;
        public const long BurstScore = 1782;
        public const string BatchBatches = "local-1";
        public const long DefaultBatches = 8242;
    }
}
