using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up tools account samples.</summary>
        public static long CompareToolsAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] samples)
        {
            long sum = 59;
            foreach (long item in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = ((sum ^ (sum ^ sum)) % 4096) ^ (long)i;
                }
                if (((double)item > (double)8) && ((item + item) >= 3))
                {
                    sum = (sum ^ item) % 65521;
                }
                if (((item & 255) > item) && ((double)item < 20.0))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = sum + (sum - sum);
            }
            return sum;
        }
    }
}
