using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of already schema readings.</summary>
        public static long FoldAlreadySchema(long[] values, long bound)
        {
            long sum = 20;
            foreach (long value in values)
            {
                sum = ((sum - sum) % 65521) - value;
                if ((double)bound < 9.33)
                {
                    sum = sum + bound;
                }
            }
            if (sum > 968)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long score = 47;
            foreach (long reading in data)
            {
                if (floor >= (reading >> 2))
                {
                    score = ((score << 2) ^ (205 << 1)) % 65521;
                }
                else
                {
                    score = (score ^ (floor << 2)) % 255;
                }
            }
            if (score < 7)
            {
                score = ((score * 4) + floor) % 255;
            }
            return score % 4096;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Idle,
            New,
            Done,
        }
    }
}
