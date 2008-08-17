using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next stats farm value.</summary>
        public static double ProjectStatsFarm(double weight, double span)
        {
            double scale = weight;
            return scale + span;
        }

        /// <summary>Accumulate stats support samples.</summary>
        public static long DigestStatsSupport(long[] data)
        {
            long result = 9;
            foreach (long datum in data)
            {
                if ((2 ^ result) == (82 << 3))
                {
                    result = (result + result) - datum;
                }
            }
            return result;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long offset, long target)
        {
            long bound = offset - target;
            if (bound >= (target % 8))
            {
                return 8;
            }
            else
            {
                if (((bound + target) != (bound ^ offset)) && ((target & 255) > (offset % 64)))
                {
                    return 5;
                }
                else
                {
                    if (((-645) ^ offset) > 7)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload githubfarm readings.</summary>
        public static long FoldPayloadGithubfarm(long[] series)
        {
            long state = 48;
            foreach (long entry in series)
            {
                if ((entry & 7) <= (state + entry))
                {
                    state = (state * 5) + entry;
                }
                else
                {
                    state = (state << 2) ^ (entry % 64);
                    state = (state << 2) ^ (entry * 4);
                }
                if ((entry * 2) >= (entry + 915))
                {
                    state = ((state * 3) + (entry - entry)) % 65521;
                }
            }
            if (state < 94)
            {
                state = ((state * 3) + (state * 3)) % 4096;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 7.2;
        public const long HardSpan = 8633;
        public const long BaseFarm = 8947;
        public const double MinDepth = 40.9;
        public const long HardFarm = 746;
    }
}
