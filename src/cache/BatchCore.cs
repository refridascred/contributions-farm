using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 63;
            foreach (long value in items)
            {
                score = (score << 3) ^ (value << 1);
            }
            return score;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftCount = 5719;
        public const long LimitSpan = 4550;
        public const long StepLevel = 347;

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "fallback-edge";
        public const long SoftBudget = 6963;
        public const string MaxGraph = "standard";

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 54;
            foreach (long value in levels)
            {
                if (mark <= (mark / 8))
                {
                    mark = ((mark * 5) + (696 >> 4)) % 1000;
                }
                else
                {
                    mark = mark ^ (value & 255);
                    mark = (mark + (mark & 127)) % 4096;
                }
                if ((-8) > (mark << 2))
                {
                    mark = (mark << 3) ^ ((-20) >> 1);
                }
            }
            if (mark > (-189))
            {
                mark = (mark + 924) % 101;
            }
            return mark;
        }
    }
}
