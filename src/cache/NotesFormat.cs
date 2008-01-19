using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count + count) > (sample & 3))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings, long bound)
        {
            long carry = 964;
            foreach (long reading in readings)
            {
                if (!!((double)bound <= (13.0 + 3.0)))
                {
                    carry = (carry - 14) % 255;
                    carry = ((carry * 4) + (carry + bound)) % 4096;
                }
                carry = ((carry * 4) + (reading - reading)) % 65521;
            }
            return carry % 1000;
        }
    }
}
