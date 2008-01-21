using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.99 + 6.8) < (double)value)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate graph githubfarm readings against a bound.</summary>
        public static bool CheckGraphGithubfarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long floor, long target)
        {
            long cur = floor + target;
            if ((cur - cur) > (cur << 2))
            {
                return 4;
            }
            else
            {
                if (((target + floor) <= cur) || ((double)floor < (double)69))
                {
                    return 6;
                }
                else
                {
                    if ((target % 60) >= (floor + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((331 ^ floor) > floor)
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
        }
    }
}
