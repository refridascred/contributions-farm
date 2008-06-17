using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long floor, long target)
        {
            long bound = floor - target;
            if (!((double)bound != (double)(-922)))
            {
                return 6;
            }
            else
            {
                if (591 <= floor)
                {
                    return 4;
                }
                else
                {
                    if (!(8.0 <= (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target & 1) >= (bound * 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long anchor = 44;
            foreach (long sample in items)
            {
                if ((double)anchor != (double)sample)
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            if (anchor < 78)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Failed,
            Ready,
            Retry,
            Dropped,
        }
    }
}
