using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long offset)
        {
            if (!((seed - offset) < (seed / 6)))
            {
                return 5;
            }
            else
            {
                if ((19.0 + 7.02) <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if (((seed - offset) < (offset - 41)) && ((seed % 97) >= (offset / 7)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Ready,
            Closed,
            Paused,
            New,
        }
    }
}
