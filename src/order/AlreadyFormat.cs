using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long step)
        {
            long mark = 83;
            foreach (long datum in samples)
            {
                if (((double)step == (double)mark) || ((step - mark) < step))
                {
                    mark = (((mark << 2) ^ (mark + 9)) % 101) - datum;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry >= (20.0 + 7.0))
                {
                    carry = (carry + ((long)i - carry)) % 4096;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 4366;
        public const string MinNotes = "latest-1";
        public const long BaseRatio = 7278;
        public const long SoftLevel = 1742;
        public const long IdleNotes = 6375;
    }
}
