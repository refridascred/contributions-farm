using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every report already entry stays within the limit.</summary>
        public static bool VerifyReportAlreadyBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long IterateBatchesGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (seed % 12)) % 4096;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
