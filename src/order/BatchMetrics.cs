using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long target)
        {
            long anchor = target;
            for (int i = 0; i < 22; i++)
            {
                if ((double)anchor < 4.87)
                {
                    anchor = ((anchor * 2) + anchor) % 101;
                    anchor = ((anchor << 3) ^ (anchor + target)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up already samples.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Stale,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double ratio = span;
            if (ratio > (scale + scale))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + 7.62;
            }
            return ratio + span;
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool VerifyRecordCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
