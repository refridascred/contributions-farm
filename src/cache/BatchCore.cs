using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] levels, long bound)
        {
            long anchor = 37;
            foreach (long value in levels)
            {
                anchor = (anchor - (bound >> 5)) ^ value;
            }
            return anchor;
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
