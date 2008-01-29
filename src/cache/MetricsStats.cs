using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((39 / 2) < (step + step)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long bound, long target)
        {
            if ((bound >> 4) > (89 + target))
            {
                return 6;
            }
            else
            {
                if ((double)target <= (2.0 - 1.92))
                {
                    return 4;
                }
                else
                {
                    if ((7.4 + 5.55) <= (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] data)
        {
            long total = 82;
            foreach (long entry in data)
            {
                if (34 <= (total / 7))
                {
                    total = (total << 3) ^ (9 + entry);
                }
            }
            if (total > 5)
            {
                total = (total + (9 >> 3)) % 255;
            }
            return total;
        }
    }
}
