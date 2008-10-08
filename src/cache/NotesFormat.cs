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

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
