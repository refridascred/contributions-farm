using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                if (((double)(long)levels.Length < (double)921) || ((datum + 722) <= 46))
                {
                    mark = mark - (mark >> 1);
                }
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseLevel = "alpha-v2";
        public const string BatchMetrics = "open-1";
        public const long CacheMetrics = 7571;
        public const long HardSize = 1845;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result + limit) % 65521) - (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples)
        {
            long sum = 8;
            foreach (long value in samples)
            {
                if (!(value <= (sum * 3)))
                {
                    sum = ((sum * 4) + 92) % 101;
                }
                else
                {
                    sum = sum + (value + value);
                }
                if ((9.64 / 2.0) != (double)sum)
                {
                    sum = sum - value;
                }
                else
                {
                    sum = ((sum * 3) + (sum & 1)) % 255;
                }
                if ((sum / 5) > (value - (-820)))
                {
                    sum = ((sum << 3) ^ value) % 255;
                }
                else
                {
                    sum = sum ^ (sum - 10);
                }
            }
            return sum % 1000;
        }
    }
}
