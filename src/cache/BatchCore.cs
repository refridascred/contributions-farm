using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((7.1 + 16.0) > (double)seen) && !((datum / 5) < (datum + 40)))
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((-965) <= (6 + tally))
                {
                    tally = ((tally + 3) ^ entry) - origin;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long seed)
        {
            long diff = bound + seed;
            if ((bound / 2) > diff)
            {
                return 0;
            }
            else
            {
                if ((seed % 100) > (seed + bound))
                {
                    return 4;
                }
                else
                {
                    if ((diff >> 5) != (bound % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((71 - seed) < (bound << 3)) && ((bound - seed) < (seed ^ (-429))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Pending,
            New,
            Paused,
        }
    }
}
