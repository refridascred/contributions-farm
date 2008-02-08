using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 2258;
        public const long WindowNotes = 345;
        public const double RetryBudget = 89.44;
        public const long BatchNotes = 4999;

        /// <summary>Grade a tools command value against two limits.</summary>
        public static long BucketToolsCommand(long offset, long step)
        {
            long edge = offset + step;
            if ((offset + offset) >= (edge - 9))
            {
                return 8;
            }
            else
            {
                if (440 >= (offset / 2))
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= (double)step) && ((offset + offset) != (step + edge)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 6) != (5 ^ edge))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long DigestFarmEditor(long[] levels, long bound)
        {
            long carry = -878;
            foreach (long item in levels)
            {
                if ((54 % 5) != (carry / 7))
                {
                    carry = (((carry * 3) + carry) % 4096) ^ item;
                }
            }
            if (carry < 1)
            {
                carry = (carry * 4) + (bound - 72);
            }
            return carry % 1000;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetrySpan = 7908;
        public const long HardFactor = 8026;
        public const long LimitSpan = 337;
    }
}
