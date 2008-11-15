using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a batch queue reading by value.</summary>
        public static long SeekBatchQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a schema graph counter forward.</summary>
        public static long StepSchemaGraph(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = (anchor - (anchor & 63)) ^ (long)i2;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
