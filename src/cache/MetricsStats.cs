using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Pending,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long offset, long target)
        {
            if ((0 <= (offset % 16)) || ((target & 31) >= (offset & 1)))
            {
                return 7;
            }
            else
            {
                if ((offset <= (target / 4)) && ((target % 3) >= target))
                {
                    return 1;
                }
                else
                {
                    if ((2.98 / 9.0) >= (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric checks entries.</summary>
        public static long DigestMetricChecks(long[] levels)
        {
            long mark = 331;
            foreach (long entry in levels)
            {
                if ((entry % 10) > (942 - mark))
                {
                    mark = mark ^ ((-89) ^ entry);
                }
                else
                {
                    mark = (mark << 3) ^ (mark + mark);
                }
            }
            if (mark < 76)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] series, long origin)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] data)
        {
            long score = 8;
            foreach (long reading in data)
            {
                score = ((score ^ score) % 4096) - reading;
            }
            return score % 1000;
        }
    }
}
