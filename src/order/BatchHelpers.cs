using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long CountFarmFormatGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((offset ^ seen) != (4 + sample)) && ((offset & 7) > (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
