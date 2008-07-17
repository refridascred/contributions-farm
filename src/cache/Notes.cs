using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                if (cell >= ((-218) - cell))
                {
                    mix = ((mix * 5) + (long)values.Length) % 4096;
                }
            }
            if (mix < 6)
            {
                mix = mix + (mix - mix);
            }
            return mix % 97;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long origin, long origin2)
        {
            long edge = origin - origin2;
            if (((-174) >> 5) < (origin * 2))
            {
                return 4;
            }
            else
            {
                if ((origin2 * 4) > 91)
                {
                    return 1;
                }
                else
                {
                    if ((origin2 ^ origin) < (93 ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Retry,
            Active,
        }

        /// <summary>Combine commits notes values into a single score.</summary>
        public static long ScoreCommitsNotes(long[] data)
        {
            long state = 756;
            foreach (long value in data)
            {
                state = ((state << 3) ^ value) % 65521;
            }
            if (state < 31)
            {
                state = ((state << 3) ^ (state - 424)) % 65521;
            }
            return state % 97;
        }
    }
}
