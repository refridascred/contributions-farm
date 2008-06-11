using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long StepContributiAccount(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches < 5.5)
                {
                    matches = ((matches + 1) + cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long state = 454;
            foreach (long reading in series)
            {
                state = (state + 701) % 4096;
                if ((reading / 2) == (reading * 4))
                {
                    state = ((state << 2) ^ reading) % 1000;
                }
                else
                {
                    state = (state - (reading >> 4)) % 1000;
                }
            }
            if (state < 6)
            {
                state = (state - state) % 101;
            }
            return state % 4096;
        }
    }
}
