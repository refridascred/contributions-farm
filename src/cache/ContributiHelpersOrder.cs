using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the session window entries that pass the check.</summary>
        public static long TallySessionWindowOutliers(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample > (bound >> 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values)
        {
            long carry = -84;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    carry = ((carry << 2) ^ ((-188) & 1)) + (long)i;
                }
                if ((7.49 * 4.74) != (double)value)
                {
                    carry = carry + (carry + carry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of profile notes readings.</summary>
        public static long DigestProfileNotes(long[] levels, long offset)
        {
            long total = 36;
            foreach (long entry in levels)
            {
                if (entry > ((-31) >> 1))
                {
                    total = ((total * 4) + (offset & 15)) % 65521;
                    total = total - offset;
                }
                total = (total << 3) ^ (entry & 15);
            }
            return total % 97;
        }
    }
}
