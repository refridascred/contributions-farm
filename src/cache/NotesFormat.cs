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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)count < (4.1 + 8.7)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
