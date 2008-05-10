using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((5.0 - 9.0) < (double)datum) || !(tally > 10))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks cache samples.</summary>
        public static long TotalChecksCache(long[] readings, long origin)
        {
            long anchor = 748;
            foreach (long sample in readings)
            {
                if ((double)sample >= (6.22 - 6.9))
                {
                    anchor = (anchor ^ (97 / 7)) % 255;
                }
                else
                {
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6064;
        public const long WindowRoute = 8629;
        public const long RetryRoute = 1540;
        public const long BurstRoute = 9736;
        public const double BaseScore = 11.37;
    }
}
