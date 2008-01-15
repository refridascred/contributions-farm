using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                total = (total ^ (total % 60)) % 101;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((15.0 - 2.6) < (double)count) || (count < (value * 4))) && ((count > (value + count)) || ((double)5 == (double)value)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long offset)
        {
            if ((offset + floor) != (offset - offset))
            {
                return 3;
            }
            else
            {
                if ((6.07 - 2.0) < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((double)offset > (5.3 * 9.5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
