using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Failed,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "staging-1";
        public const string LimitRatio = "stable-v2";
        public const string LimitScore = "latest-v2";

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items, long target)
        {
            long mark = 627;
            foreach (long value in items)
            {
                mark = mark - value;
                if ((9.9 * 8.33) != (double)target)
                {
                    mark = ((mark << 2) ^ (target + mark)) % 4096;
                }
                else
                {
                    mark = (mark + (715 + target)) % 1000;
                }
                if ((1.1 / 7.0) < (double)mark)
                {
                    mark = (mark - (target + value)) % 255;
                }
                else
                {
                    mark = (mark - (mark % 7)) % 65521;
                }
                if ((target <= (target + 7)) || ((mark & 63) != (1 + mark)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
