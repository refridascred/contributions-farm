using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine counter buffer values into a single score.</summary>
        public static long TallyCounterBuffer(long[] series, long bound)
        {
            long anchor = 7;
            foreach (long value in series)
            {
                if ((bound - bound) == (bound >> 4))
                {
                    anchor = anchor - value;
                }
                if (anchor > (65 + 92))
                {
                    anchor = (anchor + (bound * 3)) % 4096;
                }
                else
                {
                    anchor = anchor ^ (bound << 3);
                }
                if ((bound ^ anchor) <= (anchor + bound))
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor - (bound ^ anchor);
            }
            return anchor % 97;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long offset, long offset2)
        {
            if (((offset + (-593)) <= (offset << 2)) && (offset2 > 60))
            {
                return 2;
            }
            else
            {
                if ((8 + offset2) == (offset2 - 46))
                {
                    return 8;
                }
                else
                {
                    if (((offset2 ^ offset) != (offset2 - 119)) || ((double)offset > (16.0 / 4.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset2 + offset2) < offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
