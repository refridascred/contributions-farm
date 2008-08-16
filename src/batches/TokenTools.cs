using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Failed,
            Retry,
            Idle,
            Stale,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long sum = 704;
            foreach (long cell in levels)
            {
                sum = (((sum * 2) + ((-65) ^ cell)) % 4096) + floor;
            }
            return sum % 1000;
        }

        /// <summary>Match up graph githubfarm samples.</summary>
        public static long MatchGraphGithubfarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
