using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items)
        {
            long carry = 921;
            foreach (long datum in items)
            {
                carry = carry ^ (datum + carry);
            }
            if (carry > 87)
            {
                carry = (carry << 3) ^ (carry + carry);
            }
            return carry % 1000;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
