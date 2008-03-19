using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long bound, long offset)
        {
            long diff = bound - offset;
            if (offset <= (offset + 195))
            {
                return 8;
            }
            else
            {
                if (bound > (diff >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!(bound < (diff << 1)))
                    {
                        return 3;
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
