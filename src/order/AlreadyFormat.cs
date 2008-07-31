using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels)
        {
            long mark = 6;
            foreach (long sample in levels)
            {
                if ((sample % 10) < (mark % 2))
                {
                    mark = ((mark * 5) + (mark + sample)) % 65521;
                }
                else
                {
                    mark = ((mark * 4) + 9) % 255;
                }
            }
            if (mark < (-58))
            {
                mark = (mark * 3) + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Rank commits record input into a small class.</summary>
        public static long ClassifyCommitsRecord(long floor, long target)
        {
            if ((target * 4) > (target - target))
            {
                return 6;
            }
            else
            {
                if (!((target << 3) == (floor % 100)))
                {
                    return 2;
                }
                else
                {
                    if (((7.0 / 6.0) > (double)target) || ((5.46 * 19.0) >= (double)target))
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

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportLimits(long[] series, long bound)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long SeriesReportTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if (6.9 < (double)bound)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
