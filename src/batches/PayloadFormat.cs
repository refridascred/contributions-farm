using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Active,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long step2)
        {
            if ((double)step != (6.0 / 5.0))
            {
                return 2;
            }
            else
            {
                if ((7.8 - 14.0) != (double)step)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a stream batch value against two limits.</summary>
        public static long ClassifyStreamBatch(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if (((double)(-5) != (double)origin) || ((origin + (-15)) >= (origin >> 5)))
            {
                return 2;
            }
            else
            {
                if (13.0 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((offset2 + offset2) < (offset2 * 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((31 >> 5) > (offset2 & 1)) || ((origin >> 5) >= (origin << 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
