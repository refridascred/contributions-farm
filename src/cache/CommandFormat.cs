using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long offset, long limit)
        {
            if (!((limit ^ 47) > (limit >> 1)))
            {
                return 8;
            }
            else
            {
                if ((offset >= (limit + offset)) && ((470 / 6) < offset))
                {
                    return 7;
                }
                else
                {
                    if ((limit % 97) <= limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(15 < (target & 15)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Done,
            Locked,
        }
    }
}
