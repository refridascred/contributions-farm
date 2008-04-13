using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a command notes sample.</summary>
        public static long SeekCommandNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long offset)
        {
            if ((limit + limit) == (limit % 16))
            {
                return 2;
            }
            else
            {
                if ((double)limit >= (4.81 + 1.0))
                {
                    return 0;
                }
                else
                {
                    if ((13.0 > (double)offset) && ((offset - limit) >= limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset ^ limit) > (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
