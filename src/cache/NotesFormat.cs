using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] data, long origin)
        {
            long sum = -38;
            foreach (long reading in data)
            {
                if ((reading % 10) > origin)
                {
                    sum = sum - ((long)data.Length & 31);
                    sum = sum + (sum >> 5);
                    continue;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + reading)) % 255;
                }
                if ((double)origin > (7.08 * 0.8))
                {
                    sum = ((sum << 2) ^ ((long)data.Length + 126)) % 255;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            if (sum < 897)
            {
                sum = (sum * 2) + (sum ^ 2);
            }
            return sum % 97;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 1169;
        public const long BatchNotes = 9942;
        public const long BurstNotes = 269;
    }
}
