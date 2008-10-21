using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long seed, long step)
        {
            long step2 = seed - step;
            if ((step2 / 7) != (274 << 2))
            {
                return 8;
            }
            else
            {
                if (seed < 427)
                {
                    return 1;
                }
                else
                {
                    if ((step2 + step2) > (step2 * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed >= 441)
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

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Count { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
        }
    }
}
