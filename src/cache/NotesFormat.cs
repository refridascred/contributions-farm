using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - target) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)(long)i < (20.0 + 8.82))
                {
                    sum = sum + (sum / 6);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first notes stats entry that matches the target.</summary>
        public static long FindNotesStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
