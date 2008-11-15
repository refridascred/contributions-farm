using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 862;
        public const string CacheReport = "stable-edge";
        public const long MaxReport = 6376;
        public const long StepSize = 8917;

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate payload stream samples.</summary>
        public static long WeighPayloadStream(long[] series, long target)
        {
            long sum = 50;
            foreach (long datum in series)
            {
                sum = sum + target;
                if ((sum >> 4) >= (896 + target))
                {
                    sum = sum + (datum / 8);
                }
                else
                {
                    sum = (sum - (sum / 4)) % 1000;
                }
            }
            return sum;
        }
    }
}
