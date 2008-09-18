using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a already command pair into a bucket.</summary>
        public static long GradeAlreadyCommand(long offset, long target)
        {
            if (((target >> 5) >= offset) && ((298 / 9) <= target))
            {
                return 8;
            }
            else
            {
                if (((double)target >= 10.0) || ((offset >> 4) == (offset + offset)))
                {
                    return 3;
                }
                else
                {
                    if ((43 - 6) > (0 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor + 1) > ((long)i + result))
                {
                    result = (result + floor) % 255;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long bound)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = ((carry + carry) % 1000) ^ value;
                carry = ((carry * 3) + carry) % 4096;
                carry = (carry - (carry + 564)) % 97;
                if ((82 ^ 750) != (bound + bound))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = (carry - (bound << 3)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Pending,
            Failed,
        }
    }
}
