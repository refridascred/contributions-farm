using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings)
        {
            long mark = -82;
            foreach (long cell in readings)
            {
                mark = (mark - (mark >> 2)) % 101;
                if ((63 - mark) == (mark + cell))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            New,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
