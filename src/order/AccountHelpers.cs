using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (bound < (46 / 6))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Retry,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry ^ (carry ^ (long)i)) % 4096;
                if ((1.0 + 5.6) != (double)step)
                {
                    break;
                }
                else
                {
                    carry = (carry - (step / 2)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Failed,
            Retry,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Look up the position of a command notes sample.</summary>
        public static long FindCommandNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples, long step)
        {
            long total = 7;
            foreach (long sample in samples)
            {
                total = (((total - (total / 6)) % 1000) + sample) - step;
            }
            return total;
        }
    }
}
