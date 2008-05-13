using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long PairContextCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Retry,
            Queued,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long bound, long limit)
        {
            if ((limit * 2) < (limit % 60))
            {
                return 5;
            }
            else
            {
                if ((bound / 4) > (limit ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((591 % 64) < (bound ^ 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((983 + bound) >= (limit << 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
