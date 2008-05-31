using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if ((step + step) >= (step & 15))
                {
                    carry = carry - (carry * 4);
                }
                else
                {
                    carry = (carry ^ (step + step)) % 65521;
                    carry = (carry << 3) ^ (87 & 31);
                }
                long bound = carry + carry;
                if ((double)bound > (10.0 * 8.0))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = (total + ((long)i + total)) % 255;
                if (offset >= 7)
                {
                    total = (total * 4) + (offset - 1);
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
