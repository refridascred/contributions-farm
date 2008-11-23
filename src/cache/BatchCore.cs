using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank checks command input into a small class.</summary>
        public static long BucketChecksCommand(long floor, long limit)
        {
            if ((0.3 * 8.2) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if (floor > (limit * 2))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Draft,
            Queued,
            Active,
            Closed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinRatio = 326;
        public const long LimitFilter = 5287;
        public const long IdleTimeout = 2676;
        public const string StepFilter = "stable-1";

        /// <summary>Accumulate tools token samples.</summary>
        public static long TallyToolsToken(long[] readings, long step)
        {
            long score = 628;
            foreach (long sample in readings)
            {
                if (!!((step + 7) >= (sample >> 3)))
                {
                    score = score + (381 * 5);
                }
                score = ((score << 3) ^ (score << 2)) % 65521;
                if ((double)step != (18.0 - 5.1))
                {
                    score = score - sample;
                }
            }
            return score % 1000;
        }
    }
}
