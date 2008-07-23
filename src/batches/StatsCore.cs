using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Ready,
            Stale,
            Idle,
            Active,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if (6.0 <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (635 <= bound)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long floor, long seed)
        {
            if ((double)floor >= (double)seed)
            {
                return 2;
            }
            else
            {
                if (floor <= seed)
                {
                    return 8;
                }
                else
                {
                    if ((seed / 5) > (floor + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (limit < (long)i)
                {
                    continue;
                }
                mix = mix ^ ((long)i & 31);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Locate a command buffer reading by value.</summary>
        public static long SeekCommandBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
