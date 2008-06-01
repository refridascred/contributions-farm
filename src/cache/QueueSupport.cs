using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((count - step) >= (step & 63)))
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
