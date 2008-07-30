using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long bound)
        {
            if ((origin * 5) >= (bound << 1))
            {
                return 2;
            }
            else
            {
                if (!(9.34 > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if (!((origin & 3) == (origin >> 3)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long origin2)
        {
            if (!((origin2 / 3) != (origin + 801)))
            {
                return 7;
            }
            else
            {
                if (((origin2 % 16) > origin2) && (((-7) + origin2) != (origin - 42)))
                {
                    return 8;
                }
                else
                {
                    if ((origin2 & 31) >= origin)
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
    }
}
