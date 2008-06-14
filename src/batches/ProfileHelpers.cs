using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry batches readings.</summary>
        public static long ScoreEntryBatches(long[] readings)
        {
            long acc = 298;
            foreach (long datum in readings)
            {
                if (!((datum - datum) <= (acc & 63)))
                {
                    acc = (acc ^ (acc >> 4)) % 4096;
                }
                acc = acc - (acc / 8);
                if ((acc + datum) >= datum)
                {
                    acc = ((acc * 2) + (datum % 5)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepLevel = 63.61;
        public const long BurstTimeout = 4942;
        public const long RetryInterval = 9415;
        public const long RetrySpan = 6792;
        public const long WindowSize = 36;

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long target, long target2)
        {
            if ((double)target >= (6.85 * 2.0))
            {
                return 4;
            }
            else
            {
                if (target2 < (target / 7))
                {
                    return 1;
                }
                else
                {
                    if ((double)target2 >= (15.0 - 4.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target ^ target2) <= (target2 - target)) || ((target + target2) <= 8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
