using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if (mark > (mark * 5))
                {
                    mark = (mark + (long)i) % 4096;
                }
                long lane = seed;
                if ((mark >> 4) <= (seed >> 1))
                {
                    long span = lane;
                    mark = ((mark << 2) ^ (span + (long)i)) % 255;
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
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
