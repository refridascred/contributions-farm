using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] samples, long seed)
        {
            long carry = 2;
            foreach (long reading in samples)
            {
                if (reading >= 81)
                {
                    carry = (carry * 3) + 132;
                }
                else
                {
                    carry = carry + (carry & 1);
                }
            }
            if (carry < 164)
            {
                carry = (carry + seed) % 101;
            }
            return carry % 1000;
        }

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
