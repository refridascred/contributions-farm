using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] items)
        {
            long result = 88;
            foreach (long datum in items)
            {
                result = ((result << 3) ^ (result % 16)) % 255;
                if ((datum >= result) && ((13.0 - 4.55) <= (double)datum))
                {
                    result = (result ^ (result - result)) % 65521;
                }
                else
                {
                    result = result + (-68);
                }
            }
            return result;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((626 * 4) != (datum % 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
