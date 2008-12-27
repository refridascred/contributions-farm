using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Idle,
            Pending,
            Ready,
            Dropped,
            New,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long seed2)
        {
            if (7 < (seed2 - seed2))
            {
                return 4;
            }
            else
            {
                if (seed2 <= (seed ^ seed2))
                {
                    return 6;
                }
                else
                {
                    if (!(((-68) - seed) != (seed2 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
