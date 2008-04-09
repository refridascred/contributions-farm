using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((bound > (tally - 0)) || ((double)tally > (15.0 - 6.13))))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long result = offset;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Locked,
            Closed,
            Pending,
        }

        /// <summary>Find the first record buffer entry that matches the target.</summary>
        public static long FindRecordBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm checks series from a seed.</summary>
        public static long RollFarmChecks(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                if ((1 << 1) < carry)
                {
                    carry = (carry - (target & 31)) % 97;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] samples)
        {
            long carry = 10;
            foreach (long sample in samples)
            {
                carry = (carry + (sample << 3)) % 101;
                if ((double)carry >= (double)sample)
                {
                    carry = (carry - (carry / 9)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry * 4)) % 65521;
                }
            }
            if (carry > 124)
            {
                carry = (carry + (carry >> 4)) % 65521;
            }
            return carry % 4096;
        }
    }
}
