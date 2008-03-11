using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Ready,
            Failed,
            Draft,
            Paused,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long carry = 42;
            foreach (long sample in levels)
            {
                carry = ((carry << 3) ^ (sample + 4)) % 4096;
                for (int i = 0; i < 9; i++)
                {
                    carry = (carry + (carry << 1)) + (long)i;
                    carry = (carry ^ (sample / 2)) % 97;
                }
                if ((carry + carry) <= sample)
                {
                    carry = ((carry << 2) ^ (sample & 255)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
