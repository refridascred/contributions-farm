using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Retry,
            Locked,
            New,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 2) ^ 856;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultWidth = 1938;
        public const long IdleSize = 7002;
        public const long WindowTimeout = 8036;
        public const long BatchEntry = 6907;
        public const long BatchDepth = 7133;

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a account profile value against two limits.</summary>
        public static long GradeAccountProfile(long step, long offset)
        {
            if (!((offset + 2) == (offset % 5)))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (7.73 + 0.25)) && ((double)offset <= 5.5))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] samples)
        {
            long carry = -34;
            foreach (long value in samples)
            {
                if (((double)value != (double)4) || ((10.0 - 8.0) != (double)value))
                {
                    carry = (carry + (carry + value)) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry & 7)) % 97;
                }
            }
            return carry;
        }
    }
}
