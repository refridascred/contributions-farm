using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Grade a stream githubfarm value against two limits.</summary>
        public static long BucketStreamGithubfarm(long step, long offset)
        {
            if ((double)offset < (9.0 - 3.7))
            {
                return 6;
            }
            else
            {
                if (!((double)step == (2.38 + 3.54)))
                {
                    return 2;
                }
                else
                {
                    if (((offset - step) >= (step + step)) || ((double)offset < (double)9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
