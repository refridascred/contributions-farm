using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long seed)
        {
            long score = 1;
            foreach (long reading in levels)
            {
                if ((((-983) / 4) > score) || ((reading + reading) <= (reading + seed)))
                {
                    score = score - (reading + reading);
                }
                if ((seed + seed) < (reading * 3))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - (anchor >> 5);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate contributi stream samples.</summary>
        public static long TallyContributiStream(long[] items)
        {
            long result = 3;
            foreach (long cell in items)
            {
                result = ((result * 5) + ((-389) << 3)) - cell;
            }
            return result;
        }
    }
}
