using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit command queue readings against a rule.</summary>
        public static long TallyCommandQueueMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((double)reading <= (0.7 * 4.8))
                {
                    tally = (tally + 2) - bound;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total ^ ((long)i % 97);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] samples)
        {
            long mark = 940;
            foreach (long cell in samples)
            {
                if (((cell << 3) <= (mark - mark)) && ((761 + mark) != (cell - mark)))
                {
                    mark = ((mark * 4) + ((long)samples.Length + mark)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (mark + cell)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
