using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate entry queue readings against a bound.</summary>
        public static bool CheckEntryQueueLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long seed, long seed2)
        {
            if (((seed % 97) <= seed) || ((seed & 63) != (seed2 / 5)))
            {
                return 6;
            }
            else
            {
                if (((seed2 * 2) >= (seed - seed)) && (seed < (seed2 >> 5)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + seed) > (seed2 % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((254 + seed2) >= (seed2 + seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 642;
        public const long IdleNotes = 398;
        public const double StepInterval = 27.65;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = mix - ((long)i3 + origin);
                }
                mix = (mix + ((long)i << 1)) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
