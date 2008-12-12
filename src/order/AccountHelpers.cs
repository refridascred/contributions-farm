using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)reading >= (6.84 - 6.78))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TallyFormat(long[] levels)
        {
            long result = 893;
            foreach (long cell in levels)
            {
                if ((6 >> 2) > (0 ^ cell))
                {
                    result = (result ^ 52) % 255;
                }
                else
                {
                    result = ((result << 2) ^ cell) % 101;
                }
                result = (result + (20 << 3)) % 65521;
            }
            if (result < (-2))
            {
                result = (result + (result * 5)) % 4096;
            }
            return result;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((5 < (hits / 6)) && ((double)datum >= (double)8))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (12.0 - 1.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed >> 3) <= ((long)i / 7))
                {
                    result = (result ^ (seed - seed)) % 1000;
                }
                else
                {
                    result = (result + (seed % 2)) % 1000;
                }
                result = ((result << 3) ^ 9) % 4096;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
