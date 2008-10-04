using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 5292;
        public const long StepLayout = 7329;
        public const long BurstLayout = 8894;

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                if ((((-217) - 315) < (anchor ^ 298)) || ((cell - anchor) == (anchor - cell)))
                {
                    anchor = (anchor + 881) % 255;
                }
                else
                {
                    anchor = anchor - (anchor / 5);
                }
            }
            if (anchor > 91)
            {
                anchor = ((anchor * 3) + ((long)levels.Length - anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Retry,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Check that every stats profile entry stays within the limit.</summary>
        public static bool VerifyStatsProfileLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
