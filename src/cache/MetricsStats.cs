using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((double)hits > 20.0) && ((double)hits < (8.51 / 9.0)))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((6 << 3) <= count)
                {
                    count = ((count + 2) - entry) - bound;
                }
            }
            return count;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
