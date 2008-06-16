using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit - step;
            if ((double)gap < (10.0 - 2.0))
            {
                return 7;
            }
            else
            {
                if ((limit - gap) > (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9827;
        public const string MinRatio = "fallback-v2";
        public const long CacheWidth = 735;
        public const double CacheEditor = 98.4;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((reading + tally) == (tally - 5)) || ((tally * 3) >= (686 - reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
