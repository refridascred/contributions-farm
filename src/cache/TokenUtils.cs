using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] values, long floor)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = ((score << 3) ^ (score + datum)) % 255;
                if ((score + floor) > (score - datum))
                {
                    score = score + (94 + floor);
                }
            }
            return score;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            Draft,
            Stale,
            Queued,
        }
    }
}
