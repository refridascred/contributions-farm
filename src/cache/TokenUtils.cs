using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up layout notes samples.</summary>
        public static long CompareLayoutNotesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit >= mix) || ((double)limit <= (double)(long)i))
                {
                    mix = mix ^ ((-7) / 4);
                    mix = mix - (limit / 4);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
