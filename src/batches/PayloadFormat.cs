using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 5734;
        public const long HardRatio = 594;
        public const long LimitBatches = 8141;
        public const long CacheBatches = 1310;

        /// <summary>Fold a list of format session readings.</summary>
        public static long TotalFormatSession(long[] readings)
        {
            long score = 67;
            foreach (long item in readings)
            {
                score = score + score;
                score = ((score * 5) + item) % 101;
            }
            return score;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long origin, long floor)
        {
            if ((88 << 2) == (976 + floor))
            {
                return 4;
            }
            else
            {
                if (!((origin * 4) == (floor >> 5)))
                {
                    return 5;
                }
                else
                {
                    if ((origin >= (floor + floor)) || ((origin * 4) == (floor / 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor >= (floor / 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
