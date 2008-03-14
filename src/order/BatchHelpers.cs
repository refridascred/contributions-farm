using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count notes metrics pairs that satisfy a relation.</summary>
        public static long CompareNotesMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Failed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long acc = -1;
            foreach (long cell in readings)
            {
                acc = acc + cell;
                acc = (acc * 3) + (cell + cell);
                if (!(acc < (cell + acc)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
