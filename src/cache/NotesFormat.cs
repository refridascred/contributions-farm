using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Paused,
            Ready,
            Closed,
            Active,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TallyGithubfarm(long[] items, long bound)
        {
            long anchor = 635;
            foreach (long value in items)
            {
                if (anchor < value)
                {
                    anchor = anchor - bound;
                }
                if (8 >= (bound * 2))
                {
                    anchor = (anchor - anchor) % 97;
                }
            }
            if (anchor > 1)
            {
                anchor = anchor + 99;
            }
            return anchor;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long SeekGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
