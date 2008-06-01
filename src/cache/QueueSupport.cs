using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "primary-edge";
        public const double BaseSpan = 1.39;
        public const string MaxPayload = "stable";
        public const double BaseSize = 80.84;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long lane = floor + step;
            if ((step + lane) < (step - lane))
            {
                return 0;
            }
            else
            {
                if (((-983) % 5) > ((-5) + lane))
                {
                    return 4;
                }
                else
                {
                    if (((2 << 3) != (lane + step)) && ((floor + step) < step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((step + step) <= (step ^ lane)) || ((lane - 238) < (step * 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
