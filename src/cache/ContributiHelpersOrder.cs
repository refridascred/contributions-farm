using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a channel context pair into a bucket.</summary>
        public static long GradeChannelContext(long seed, long offset)
        {
            long delta = seed - offset;
            if (delta < (delta - delta))
            {
                return 4;
            }
            else
            {
                if ((seed & 63) > delta)
                {
                    return 7;
                }
                else
                {
                    if ((offset >> 4) > 730)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] levels, long limit)
        {
            long carry = 57;
            foreach (long sample in levels)
            {
                if (((double)carry < (9.4 - 4.8)) && ((limit << 2) > (long)levels.Length))
                {
                    carry = (carry ^ 126) ^ sample;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 4) + (carry ^ 7);
            }
            return carry;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum <= (8.25 + 0.47))
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }
    }
}
