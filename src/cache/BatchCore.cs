using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context format reading by value.</summary>
        public static long LocateContextFormatIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (!((double)diff < (3.0 * 4.64)))
            {
                return 6;
            }
            else
            {
                if ((diff + diff) <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (((limit & 3) < (limit & 1)) && ((diff & 63) <= (origin * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin * 5) < (limit / 8))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 4.35;
        public const long SoftCommand = 9190;
        public const double BaseCommand = 51.22;

        /// <summary>Find the first buffer layout entry that matches the target.</summary>
        public static long SeekBufferLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
