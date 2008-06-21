using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long bound)
        {
            if ((bound & 7) == (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((origin + bound) == (197 - 0))
                {
                    return 6;
                }
                else
                {
                    if (((bound + bound) == (origin + bound)) && ((origin >> 2) == (bound & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) <= (bound - 945))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Failed,
            Draft,
            Queued,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long mix = 3;
            foreach (long item in data)
            {
                mix = ((((mix << 2) ^ (mix * 2)) % 101) + item) + seed;
                mix = (mix + (long)data.Length) % 255;
            }
            return mix % 1000;
        }
    }
}
