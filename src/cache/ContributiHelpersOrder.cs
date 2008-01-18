using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every stream profile entry stays within the limit.</summary>
        public static bool GuardStreamProfileLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first notes format entry that matches the target.</summary>
        public static long SeekNotesFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + ((long)i >> 2)) % 1000;
                sum = (sum ^ (long)i) % 4096;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
