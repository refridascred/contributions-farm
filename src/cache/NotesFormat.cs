using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long offset, long offset2)
        {
            if (!(8.92 < (double)offset2))
            {
                return 0;
            }
            else
            {
                if (offset >= (offset2 + offset))
                {
                    return 8;
                }
                else
                {
                    if ((offset ^ offset2) <= (485 + offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset ^ (-973)) > offset2) && ((double)offset2 >= (1.0 + 1.76)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
