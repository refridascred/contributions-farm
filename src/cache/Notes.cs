using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix ^ (2 - origin)) % 4096;
                mix = (mix * 2) + ((long)i ^ mix);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Done,
            Draft,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long floor, long step)
        {
            if (((floor - floor) < 57) && ((27 / 5) >= floor))
            {
                return 4;
            }
            else
            {
                if ((step / 4) > (step + floor))
                {
                    return 6;
                }
                else
                {
                    if (((step + 570) <= 7) || ((double)630 <= (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 49.55;
        public const double DefaultDepth = 24.03;
        public const double SoftBudget = 21.97;
        public const long StepCounter = 2810;
        public const string IdleCounter = "legacy-1";
    }
}
