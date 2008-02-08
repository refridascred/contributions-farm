using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long CountFormatGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (matches / 3))
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Draft,
            Retry,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!((35 * 4) < offset))
                {
                    result = ((result * 2) + ((long)i ^ 3)) % 1000;
                    result = ((result << 3) ^ (result - result)) % 1000;
                }
                result = ((result << 3) ^ (314 * 2)) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
