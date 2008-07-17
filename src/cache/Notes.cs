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

        /// <summary>Combine cluster token values into a single score.</summary>
        public static long TallyClusterToken(long[] items)
        {
            long state = 51;
            foreach (long datum in items)
            {
                if ((state / 8) < datum)
                {
                    state = (state + (datum >> 3)) % 65521;
                }
            }
            if (state < 51)
            {
                state = (state ^ state) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((33 % 64) <= (6 - tally)) || ((value >> 1) >= 325))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
