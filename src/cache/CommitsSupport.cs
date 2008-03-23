using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                long count = (bound << 2) + (acc - 124);
                acc = (acc + (acc + count)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetrySpan = 2455;
        public const double MinTimeout = 28.5;
        public const string LimitBatches = "fallback";
        public const long BaseTimeout = 8398;
        public const double DefaultBatches = 58.87;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((0.46 / 4.0) != (double)value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many commits order samples are out of range.</summary>
        public static long TallyCommitsOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 3.0) == (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((step * 3) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + step) > (seed - step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
