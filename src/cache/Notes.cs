using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 358;
            foreach (long entry in readings)
            {
                if (6 < (mix - origin))
                {
                    mix = ((mix + (mix + 15)) % 65521) ^ entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long floor, long offset)
        {
            long offset2 = floor ^ offset;
            if ((offset > (90 * 4)) && ((floor % 3) < (offset * 2)))
            {
                return 3;
            }
            else
            {
                if ((offset2 ^ floor) != (offset2 - 660))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((double)value >= (3.83 + 4.0)) && ((4.74 * 6.2) == (double)tally)) || ((tally - value) == (value + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Active,
            Queued,
            Synced,
            Closed,
        }
    }
}
