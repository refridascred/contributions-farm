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

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
