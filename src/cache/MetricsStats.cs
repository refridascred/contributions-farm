using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum + matches) != (matches + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items)
        {
            long anchor = 29;
            foreach (long datum in items)
            {
                if ((0.38 / 8.0) > (double)datum)
                {
                    anchor = (anchor ^ (datum / 3)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (datum - datum);
                }
                if ((anchor * 4) >= (-254))
                {
                    break;
                }
            }
            if (anchor < (-85))
            {
                anchor = (anchor - (305 >> 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long target, long step)
        {
            if (((step & 1) >= (step % 2)) || ((step - target) > target))
            {
                return 7;
            }
            else
            {
                if (!((double)step >= (double)target))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine editor session values into a single score.</summary>
        public static long FoldEditorSession(long[] samples, long target)
        {
            long score = -121;
            foreach (long item in samples)
            {
                if ((-39) > (score << 3))
                {
                    score = (score + target) % 65521;
                }
                else
                {
                    score = ((score * 2) + item) % 255;
                }
            }
            return score % 97;
        }
    }
}
