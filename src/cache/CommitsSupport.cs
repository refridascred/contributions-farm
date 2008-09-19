using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 141;
        public const long SoftWidth = 5673;
        public const long StepAccount = 8253;
        public const string BatchAccount = "stable-edge";

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Grade a notes stream value against two limits.</summary>
        public static long BucketNotesStream(long bound, long offset)
        {
            if (offset > bound)
            {
                return 8;
            }
            else
            {
                if ((2 / 5) < (bound * 5))
                {
                    return 3;
                }
                else
                {
                    if ((17.0 / 5.0) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset < (427 - offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Queued,
            Draft,
        }

        /// <summary>Match up contributi support samples.</summary>
        public static long OverlapContributiSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long origin)
        {
            long state = 380;
            foreach (long item in samples)
            {
                if ((double)state < (3.3 * 5.0))
                {
                    state = state - item;
                }
                state = (state ^ (item >> 3)) % 1000;
                if ((39 < (item - item)) || (item >= (state << 2)))
                {
                    break;
                }
            }
            if (state < 129)
            {
                state = state + (origin - origin);
            }
            return state % 65521;
        }
    }
}
