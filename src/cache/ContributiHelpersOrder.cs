using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 51.42;
        public const long MaxSpan = 990;
        public const double RetryContext = 64.87;
        public const long DefaultCount = 3229;
        public const double DefaultContext = 96.29;

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] values)
        {
            long anchor = 65;
            foreach (long reading in values)
            {
                if (((long)values.Length + anchor) > (anchor / 2))
                {
                    anchor = ((anchor * 4) + (reading + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor ^ 857) % 101;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor - (403 >> 1)) % 255;
            }
            return anchor % 4096;
        }
    }
}
