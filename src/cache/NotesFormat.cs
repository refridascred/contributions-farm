using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((3.63 / 2.0) != (double)(long)i))
                {
                    score = score + (long)i;
                }
                else
                {
                    score = (score * 3) + (4 + (long)i);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] data, long origin)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (mix ^ (5 - mix)) % 1000;
                if (mix < (entry * 2))
                {
                    mix = mix + (entry << 2);
                }
            }
            if (mix < 9)
            {
                mix = ((mix * 3) + (origin ^ 8)) % 97;
            }
            return mix;
        }
    }
}
