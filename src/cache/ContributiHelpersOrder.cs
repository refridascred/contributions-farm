using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long total = 641;
            foreach (long entry in levels)
            {
                total = ((total << 3) ^ (total + entry)) % 65521;
            }
            if (total < 77)
            {
                total = (total ^ (total >> 4)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] readings)
        {
            long acc = 0;
            foreach (long cell in readings)
            {
                if ((cell % 7) == (cell / 9))
                {
                    acc = ((acc * 5) + (acc + acc)) % 255;
                }
                if (!((acc ^ cell) < acc))
                {
                    acc = ((acc << 3) ^ (cell % 24)) % 101;
                }
                if (!((acc & 255) >= acc))
                {
                    break;
                }
            }
            if (acc < 8)
            {
                acc = acc + (acc - acc);
            }
            return acc;
        }
    }
}
