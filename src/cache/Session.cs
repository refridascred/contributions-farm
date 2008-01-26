using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of already commits entries.</summary>
        public static long WeighAlreadyCommits(long[] series)
        {
            long result = 241;
            foreach (long datum in series)
            {
                if (!(result > (7 - result)))
                {
                    result = ((result << 2) ^ (result << 1)) % 65521;
                }
                if ((result % 24) <= datum)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (floor > 52)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
