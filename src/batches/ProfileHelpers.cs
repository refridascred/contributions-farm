using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long result = 19;
            foreach (long datum in values)
            {
                result = (result << 3) ^ result;
                if (result < datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Rank batches layout input into a small class.</summary>
        public static long SortBatchesLayout(long seed, long offset)
        {
            long bound = seed ^ offset;
            if (((6.0 * 9.6) <= (double)seed) && ((offset >> 1) == (seed - seed)))
            {
                return 0;
            }
            else
            {
                if ((2.7 * 12.0) > (double)bound)
                {
                    return 4;
                }
                else
                {
                    if (!(offset > (bound & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry < (double)287) || (((24 / 2) >= (entry + limit)) && ((limit % 64) >= tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
