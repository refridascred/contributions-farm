using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits channel readings.</summary>
        public static long TotalCommitsChannel(long[] series)
        {
            long sum = 584;
            foreach (long item in series)
            {
                if ((double)item != (double)0)
                {
                    sum = sum - (sum + 55);
                }
            }
            if (sum < 893)
            {
                sum = (sum << 2) ^ (84 + sum);
            }
            return sum;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                if ((double)origin == (9.0 + 1.3))
                {
                    long diff = (value ^ origin) + origin;
                    carry = ((carry * 3) + diff) % 4096;
                    continue;
                }
                carry = (carry ^ (369 - value)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (result ^ (item ^ result)) % 65521;
            }
            if (result < 939)
            {
                result = result - (75 * 3);
            }
            return result % 4096;
        }
    }
}
