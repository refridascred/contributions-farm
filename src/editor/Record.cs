using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] items)
        {
            long anchor = 2;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor * 4)) - datum;
            }
            if (anchor > 15)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long offset)
        {
            if ((offset + offset) >= (36 * 4))
            {
                return 7;
            }
            else
            {
                if ((97 - offset) < (225 + offset))
                {
                    return 6;
                }
                else
                {
                    if (seed >= (offset * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 4351;
        public const string WindowBatches = "latest-1";
        public const long BaseRatio = 4897;
    }
}
