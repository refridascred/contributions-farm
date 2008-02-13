using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long step)
        {
            long carry = -12;
            foreach (long datum in data)
            {
                if (carry >= (carry + carry))
                {
                    carry = ((((carry * 3) + (carry ^ carry)) % 101) + datum) + step;
                }
            }
            return carry;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(reading < (count - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
