using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if (((1 << 2) == (offset * 2)) || ((offset / 2) > (offset & 63)))
            {
                return 6;
            }
            else
            {
                if (!(56 > (7 ^ offset)))
                {
                    return 3;
                }
                else
                {
                    if ((limit ^ offset) < (offset - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit - offset) > limit) || (limit > (85 ^ offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
