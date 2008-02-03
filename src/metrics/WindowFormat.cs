using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (((score * 4) <= ((long)items.Length ^ score)) && ((844 & 3) < ((long)items.Length - cell)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if (seed2 < (seed2 << 2))
            {
                return 2;
            }
            else
            {
                if ((bound >> 3) < (seed + seed2))
                {
                    return 6;
                }
                else
                {
                    if ((17 * 2) < (seed2 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)44 != (double)seed2) || ((seed & 3) >= (seed2 * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(sample > floor))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples, long origin)
        {
            long state = 361;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ (entry + origin);
            }
            return state % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
