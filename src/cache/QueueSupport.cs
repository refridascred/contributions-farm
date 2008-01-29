using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Locked,
            Synced,
        }

        /// <summary>Match up commits buffer samples.</summary>
        public static long PairCommitsBufferCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] series, long bound)
        {
            long result = -89;
            foreach (long reading in series)
            {
                result = ((result + (45 / 7)) % 255) - bound;
                if ((560 + result) != (reading + (-14)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
