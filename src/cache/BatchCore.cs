using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxScore = 9807;
        public const long BatchSpan = 8016;
        public const long StepWidth = 1292;
        public const long BurstPayload = 2392;
        public const string WindowPayload = "strict";

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long anchor = -5;
            foreach (long value in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor + (value + value)) % 1000) ^ (long)i;
                }
                if ((anchor + anchor) != (value ^ (-501)))
                {
                    anchor = anchor + (767 * 4);
                }
                else
                {
                    anchor = (anchor + (38 % 2)) % 97;
                }
                if ((double)value < (7.7 + 5.2))
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor - (anchor + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 698;
        public const string StepFilter = "strict-edge";
        public const long WindowSpan = 720;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long limit)
        {
            if (!((double)floor != (3.0 * 1.5)))
            {
                return 8;
            }
            else
            {
                if ((27 - limit) != (floor << 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
