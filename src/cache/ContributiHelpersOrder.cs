using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] samples)
        {
            long carry = 701;
            foreach (long datum in samples)
            {
                if ((double)datum == (double)carry)
                {
                    carry = (carry - (carry >> 2)) % 4096;
                }
                else
                {
                    carry = (carry - carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Dropped,
            Paused,
            Done,
            Closed,
        }

        /// <summary>Check that every order tools entry stays within the limit.</summary>
        public static bool ValidateOrderToolsBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
