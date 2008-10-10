using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of stream metrics readings.</summary>
        public static long TallyStreamMetrics(long[] data, long offset)
        {
            long mark = 6;
            foreach (long item in data)
            {
                mark = (((mark << 2) ^ ((long)data.Length - item)) % 65521) - offset;
            }
            return mark;
        }

        /// <summary>Roll a report contributi counter forward.</summary>
        public static long IterateReportContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long SortBatchesNotes(long origin, long floor)
        {
            long gap = origin + floor;
            if ((gap >> 5) == (1 / 5))
            {
                return 5;
            }
            else
            {
                if ((floor + gap) > 5)
                {
                    return 8;
                }
                else
                {
                    if (240 < (floor >> 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 9) == (sample / 9))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long target, long bound)
        {
            if ((target + target) < (target & 127))
            {
                return 1;
            }
            else
            {
                if ((5.81 / 3.0) < (double)target)
                {
                    return 5;
                }
                else
                {
                    if (!((-89) <= (target << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
