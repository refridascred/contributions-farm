using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Rank { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((bound - 413) <= (2 * 2))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) > (bound + bound))
                {
                    return 1;
                }
                else
                {
                    if (((target + bound) != (39 & 3)) && ((bound << 3) <= (bound - bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((19.0 / 7.0) == (double)bound))
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

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long item in readings)
            {
                if ((limit <= (carry % 60)) || (carry > (item / 7)))
                {
                    carry = ((carry * 3) + (item + limit)) % 255;
                }
            }
            return carry;
        }
    }
}
