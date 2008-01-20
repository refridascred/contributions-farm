using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((matches / 2) > reading) && ((floor % 97) > (floor >> 3))) || ((matches - matches) <= reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (4 >> 2)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i >= ((long)i ^ offset))
                {
                    total = (total ^ (offset ^ (long)i)) % 65521;
                }
                if (((double)offset < (double)894) || ((total + offset) > (offset & 7)))
                {
                    total = (total ^ (long)i) % 97;
                    total = ((total * 4) + offset) % 101;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
