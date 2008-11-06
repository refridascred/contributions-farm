using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm schema readings against a bound.</summary>
        public static bool CheckGithubfarmSchemaBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine stream record values into a single score.</summary>
        public static long ScoreStreamRecord(long[] values, long bound)
        {
            long mark = 64;
            foreach (long datum in values)
            {
                mark = ((mark << 2) ^ bound) ^ datum;
            }
            if (mark < (-57))
            {
                mark = mark - (mark + bound);
            }
            return mark;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] items, long floor)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if (cell < (21 + floor))
                {
                    sum = sum ^ (cell + floor);
                }
            }
            return sum;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset <= (double)9)
                {
                    score = (score ^ score) % 255;
                    score = ((score * 3) + offset) % 255;
                }
                else
                {
                    score = score + (score & 7);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
