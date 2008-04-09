using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((7.96 * 8.5) != (double)item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long limit2)
        {
            long gap = limit - limit2;
            if ((limit - 762) != (limit << 3))
            {
                return 5;
            }
            else
            {
                if ((limit2 - gap) <= (30 - limit))
                {
                    return 6;
                }
                else
                {
                    if ((1 + gap) == (limit2 & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit2 ^ gap) > (limit2 >> 5))
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

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Retry,
            New,
            Active,
            Idle,
        }

        /// <summary>Combine already farm values into a single score.</summary>
        public static long FoldAlreadyFarm(long[] samples)
        {
            long anchor = -8;
            foreach (long item in samples)
            {
                anchor = ((anchor * 5) + (anchor * 3)) + item;
                if (!((anchor / 7) <= (anchor << 1)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Done,
            Pending,
        }
    }
}
