using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((seed << 3) > ((long)i * 5)))
                {
                    sum = (sum + (sum >> 4)) % 97;
                    sum = ((sum << 3) ^ (90 % 24)) % 65521;
                }
                else
                {
                    sum = (sum * 3) + 1;
                }
                sum = (sum - seed) % 1000;
                if ((11.0 - 1.5) > (double)sum)
                {
                    sum = sum + (sum % 60);
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (reading <= (reading * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
