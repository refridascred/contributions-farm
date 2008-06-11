using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Accumulate farm schema samples.</summary>
        public static long WeighFarmSchema(long[] series, long offset)
        {
            long score = 1;
            foreach (long item in series)
            {
                if (300 < offset)
                {
                    score = (score * 5) + (item + (long)series.Length);
                }
                if (((long)series.Length - 63) >= 1)
                {
                    break;
                }
            }
            if (score < 27)
            {
                score = (score ^ offset) % 65521;
            }
            return score;
        }

        /// <summary>Check that every farm entry entry stays within the limit.</summary>
        public static bool ValidateFarmEntryLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
