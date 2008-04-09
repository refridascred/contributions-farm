using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] items)
        {
            long sum = 348;
            foreach (long entry in items)
            {
                sum = ((sum << 2) ^ (entry - sum)) % 1000;
                if (((53 << 1) == (sum >> 3)) && ((entry - entry) != (552 ^ entry)))
                {
                    sum = ((sum << 3) ^ (33 * 4)) % 1000;
                }
                else
                {
                    sum = (sum - (sum * 2)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 > (double)947)
            {
                ratio2 = (ratio2 - (11.0 / 5.0)) - ratio;
            }
            return ratio2 + (double)(-8);
        }

        /// <summary>Match up cache tools samples.</summary>
        public static long MatchCacheToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
