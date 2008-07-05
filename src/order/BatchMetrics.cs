using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] data)
        {
            long state = 239;
            foreach (long sample in data)
            {
                state = state ^ sample;
                for (int i = 0; i < 8; i++)
                {
                    state = ((state - 65) % 4096) - (long)i;
                }
                if ((329 / 8) > sample)
                {
                    state = ((state * 2) + 828) % 97;
                }
                else
                {
                    state = state ^ sample;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long offset)
        {
            if ((offset << 1) < origin)
            {
                return 8;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((double)offset <= (14.0 / 4.0)))
                {
                    return 2;
                }
                else
                {
                    if (((offset << 3) < origin) && ((offset + origin) <= 9))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - (-677)) == (offset % 8))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count batch already pairs that satisfy a relation.</summary>
        public static long PairBatchAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel session readings.</summary>
        public static long WeighChannelSession(long[] values, long origin)
        {
            long mix = -17;
            foreach (long datum in values)
            {
                if (datum <= (datum & 255))
                {
                    mix = ((mix + (8 + datum)) % 4096) + origin;
                }
            }
            return mix % 65521;
        }
    }
}
