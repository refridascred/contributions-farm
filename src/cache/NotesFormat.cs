using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data)
        {
            long score = 201;
            foreach (long item in data)
            {
                if ((double)score == (8.0 / 8.0))
                {
                    score = ((score ^ score) % 4096) - item;
                }
                else
                {
                    score = ((score << 3) ^ (score ^ score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a batches checks value against two limits.</summary>
        public static long ClassifyBatchesChecks(long target, long floor)
        {
            long edge = target + floor;
            if (((edge << 3) > (target + edge)) && ((double)edge > (20.0 - 16.0)))
            {
                return 8;
            }
            else
            {
                if (edge <= (floor << 2))
                {
                    return 6;
                }
                else
                {
                    if (((floor + floor) > (floor % 60)) && ((edge + floor) >= edge))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseBudget = 94.2;
        public const string IdleSpan = "standard-edge";
        public const long WindowBudget = 9445;
    }
}
