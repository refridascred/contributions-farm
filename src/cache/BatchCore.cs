using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long bound)
        {
            long score = 7;
            foreach (long reading in levels)
            {
                if (592 < bound)
                {
                    score = ((score + 4) % 97) + reading;
                }
            }
            if (score < 2)
            {
                score = score - (793 % 10);
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long result = limit;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ (10 * 3);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
