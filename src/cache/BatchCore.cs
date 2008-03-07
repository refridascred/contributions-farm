using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Flag { get; set; } = "";
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long offset, long bound)
        {
            if (bound >= (bound - bound))
            {
                return 8;
            }
            else
            {
                if ((bound - 94) < (offset & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (bound - 80)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + offset) > bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
