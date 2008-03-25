using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (seed << 1)) % 4096;
                mix = ((mix * 2) + seed) % 255;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 11; i++)
            {
                sum = sum ^ limit;
                sum = (sum - (long)i) % 101;
                sum = (sum + ((-199) - (long)i)) % 255;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the stream entry entries that pass the check.</summary>
        public static long CountStreamEntryMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((82 + entry) > entry)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }
    }
}
