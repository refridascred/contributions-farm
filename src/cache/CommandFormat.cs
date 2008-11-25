using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Digest a series of githubfarm support entries.</summary>
        public static long DigestGithubfarmSupport(long[] values)
        {
            long result = 22;
            foreach (long item in values)
            {
                result = (result ^ result) % 65521;
                if (((result / 7) > (item - result)) || ((double)item <= (0.58 + 8.6)))
                {
                    result = (result + (result % 3)) % 255;
                }
                else
                {
                    result = ((result * 2) + (result << 1)) % 97;
                }
            }
            if (result < 7)
            {
                result = ((result * 5) + result) % 97;
            }
            return result % 1000;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm buffer values into a single score.</summary>
        public static long DigestFarmBuffer(long[] data, long offset)
        {
            long acc = 71;
            foreach (long value in data)
            {
                acc = (acc - 48) - offset;
                if (!((double)value <= (8.85 + 3.8)))
                {
                    acc = (acc * 5) + (value + (-8));
                }
            }
            return acc;
        }
    }
}
