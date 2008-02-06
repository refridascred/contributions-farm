using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            long step = target + offset;
            if (((target << 1) < target) && ((double)target != (19.0 + 6.6)))
            {
                return 2;
            }
            else
            {
                if ((offset - step) < 7)
                {
                    return 0;
                }
                else
                {
                    if ((7.0 / 6.0) <= (double)step)
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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Classify a channel metric pair into a bucket.</summary>
        public static long GradeChannelMetric(long offset, long step)
        {
            if (offset <= (offset >> 3))
            {
                return 4;
            }
            else
            {
                if (offset <= step)
                {
                    return 1;
                }
                else
                {
                    if (((offset & 63) > (step & 127)) && (1.0 < (double)offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data, long offset)
        {
            long anchor = 560;
            foreach (long reading in data)
            {
                if (((2.1 / 7.0) < (double)anchor) || (offset > (anchor - offset)))
                {
                    anchor = ((anchor << 3) ^ (57 * 2)) % 1000;
                    break;
                }
                if ((reading + offset) == (offset + 4))
                {
                    anchor = (anchor ^ (reading & 1)) % 1000;
                }
            }
            if (anchor > 380)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long origin, long bound)
        {
            long step = origin - bound;
            if (step < (bound / 5))
            {
                return 5;
            }
            else
            {
                if (step >= ((-6) % 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)step != (6.0 * 8.99))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
