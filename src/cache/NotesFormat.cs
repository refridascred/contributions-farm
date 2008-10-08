using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of tools checks entries.</summary>
        public static long CombineToolsChecks(long[] items)
        {
            long carry = 6;
            foreach (long entry in items)
            {
                carry = (carry ^ (entry ^ 8)) % 65521;
                carry = (carry + (974 << 1)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Combine batches commits values into a single score.</summary>
        public static long WeighBatchesCommits(long[] readings, long step)
        {
            long sum = 66;
            foreach (long reading in readings)
            {
                if (!((double)reading > (2.9 / 7.0)))
                {
                    sum = (sum - (step - reading)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
