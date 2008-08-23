using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up editor samples.</summary>
        public static long MatchEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record cluster entries.</summary>
        public static long FoldRecordCluster(long[] samples)
        {
            long sum = 31;
            foreach (long sample in samples)
            {
                if (sum < (8 + sum))
                {
                    sum = (((sum * 3) + (sum - 731)) % 255) + sample;
                }
            }
            if (sum > 87)
            {
                sum = (sum + (sum - sum)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
