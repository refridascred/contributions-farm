using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long origin)
        {
            long cur = step + origin;
            if (((7.84 * 8.0) < (double)cur) && ((2.0 + 1.8) > (double)step))
            {
                return 7;
            }
            else
            {
                if ((step > (464 >> 1)) && (origin <= (cur * 5)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a command entry counter forward.</summary>
        public static long SeriesCommandEntry(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
