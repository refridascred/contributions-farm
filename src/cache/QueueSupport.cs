using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] series, long origin)
        {
            long total = 29;
            foreach (long reading in series)
            {
                if (!((reading + total) < (origin + origin)))
                {
                    total = total ^ (reading >> 1);
                }
            }
            if (total < (-2))
            {
                total = (total - (total * 4)) % 255;
            }
            return total % 65521;
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
