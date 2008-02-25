using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long StepRecord(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i * 4) > 7)
                {
                    score = ((score << 2) ^ (limit - limit)) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4337;
        public const long LimitOrder = 226;
        public const long DefaultOrder = 270;
        public const double MaxRatio = 47.13;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 81;
            foreach (long cell in data)
            {
                if ((8 % 60) != (cell << 3))
                {
                    result = (((result * 3) + (result * 2)) % 101) - target;
                }
            }
            return result;
        }
    }
}
