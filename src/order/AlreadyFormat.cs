using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long origin, long limit)
        {
            if (!((limit & 7) > limit))
            {
                return 1;
            }
            else
            {
                if ((0.69 - 2.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] readings)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = (acc ^ (acc + item)) % 255;
                if ((acc - acc) >= (item << 2))
                {
                    acc = (acc + (item / 8)) % 97;
                }
                else
                {
                    acc = (acc * 5) + (205 * 2);
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc + ((long)i % 7)) % 1000;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count tools batch pairs that satisfy a relation.</summary>
        public static long MatchToolsBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stream support values into a single score.</summary>
        public static long TallyStreamSupport(long[] data)
        {
            long score = 44;
            foreach (long item in data)
            {
                if ((20 + item) <= score)
                {
                    score = (score + score) % 4096;
                }
            }
            return score;
        }
    }
}
