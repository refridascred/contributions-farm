using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of editor tools entries.</summary>
        public static long TallyEditorTools(long[] readings, long target)
        {
            long score = 8;
            foreach (long item in readings)
            {
                score = (((score * 3) + (score >> 4)) % 255) + item;
                if ((9 >> 4) != (score - target))
                {
                    score = (score - (target & 3)) % 4096;
                }
            }
            return score % 97;
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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long limit, long limit2)
        {
            if ((limit2 ^ limit) < (limit2 * 4))
            {
                return 4;
            }
            else
            {
                if (16 <= (72 + limit))
                {
                    return 3;
                }
                else
                {
                    if ((60 + limit2) < (6 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit2 >= (3.8 * 19.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
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
