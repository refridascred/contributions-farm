using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] data, long offset)
        {
            long total = 0;
            foreach (long reading in data)
            {
                if ((double)total <= 3.8)
                {
                    total = (total ^ (offset & 63)) - reading;
                }
                else
                {
                    total = (total - offset) % 255;
                }
            }
            if (total > 9)
            {
                total = ((total * 3) + (offset % 10)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Pending,
            Dropped,
        }

        /// <summary>Find the first editor contributi entry that matches the target.</summary>
        public static long FindEditorContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
