using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long target, long step)
        {
            if ((target % 7) > (148 & 255))
            {
                return 7;
            }
            else
            {
                if (((-776) + 7) <= (step >> 4))
                {
                    return 4;
                }
                else
                {
                    if ((target << 1) > (step % 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step ^ 7) >= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((origin % 5) < origin)
                {
                    count = (count + 3) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count >> 4) > (datum * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary-edge";
        public const long BurstRoute = 6733;
        public const long BaseRoute = 6800;
        public const long MinRoute = 895;
        public const long LimitRatio = 1564;

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
