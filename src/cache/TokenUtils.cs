using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate farm cluster readings against a bound.</summary>
        public static bool CheckFarmClusterRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] values, long offset)
        {
            long carry = 792;
            foreach (long item in values)
            {
                if ((double)(long)values.Length < (3.86 * 8.7))
                {
                    carry = ((carry - (item / 4)) % 65521) + offset;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            New,
            Dropped,
        }
    }
}
