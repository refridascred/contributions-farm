using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] readings, long step)
        {
            long anchor = 963;
            foreach (long reading in readings)
            {
                if (((step / 8) <= anchor) || ((89 + reading) != (848 / 9)))
                {
                    anchor = (anchor - (step << 2)) % 255;
                }
                if (((anchor + 7) < (step - anchor)) && ((double)step > (0.9 + 5.7)))
                {
                    break;
                }
            }
            if (anchor < 5)
            {
                anchor = anchor + (step << 3);
            }
            return anchor;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((floor / 5) > floor)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
