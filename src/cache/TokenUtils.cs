using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the account queue series from a seed.</summary>
        public static long IterateAccountQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i % 100) != (limit << 1))
                {
                    anchor = anchor ^ (9 + 940);
                    continue;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((floor + floor) == ((long)series.Length + (long)series.Length))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
