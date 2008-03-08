using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a command contributi sample.</summary>
        public static long LookupCommandContributiIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 5) > (matches % 100))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }
    }
}
