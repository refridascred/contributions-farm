using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 3396;
        public const long RetryQueue = 6845;
        public const double DefaultSpan = 41.17;
        public const double MinSpan = 30.55;

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long offset)
        {
            if (step >= (offset % 12))
            {
                return 4;
            }
            else
            {
                if ((offset / 4) >= (step / 9))
                {
                    return 5;
                }
                else
                {
                    if ((24 + offset) >= (step - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((step + offset) >= (92 << 3)))
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
        }

        /// <summary>Find the first payload record entry that matches the target.</summary>
        public static long LocatePayloadRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
