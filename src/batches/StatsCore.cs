using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix * 3) + ((long)i + 6)) % 4096) ^ (long)i2;
                    mix = (mix ^ (mix + 34)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1.0 * 12.0) > (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + ((long)i + 2)) % 1000;
                if (!(((-571) - origin) < origin))
                {
                    carry = ((carry * 2) + (origin - origin)) % 65521;
                    carry = (carry + (carry + origin)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step + count) >= (step + 32)) && ((3 - count) < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
