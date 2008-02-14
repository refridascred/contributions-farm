using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Stale,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            if ((54 - 484) == (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) <= (971 ^ 62))
                    {
                        return 4;
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
