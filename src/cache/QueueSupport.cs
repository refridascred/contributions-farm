using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of support format readings.</summary>
        public static long ScoreSupportFormat(long[] series)
        {
            long result = 3;
            foreach (long cell in series)
            {
                result = (result + (cell >> 2)) % 97;
                if (((cell + cell) > (result - 3)) && (cell > (cell ^ result)))
                {
                    result = (result ^ result) % 101;
                }
                else
                {
                    result = result - (cell % 12);
                }
            }
            return result;
        }

        /// <summary>Audit contributi githubfarm readings against a rule.</summary>
        public static long MeasureContributiGithubfarmMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (!((matches < (matches + sample)) || ((97 * 2) >= (matches * 4))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long origin)
        {
            if ((offset >= (origin ^ origin)) || ((10 >> 1) > origin))
            {
                return 4;
            }
            else
            {
                if (12.0 <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
