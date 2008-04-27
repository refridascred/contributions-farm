using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (0.69 <= (double)cell)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate account layout samples.</summary>
        public static long TallyAccountLayout(long[] readings, long offset)
        {
            long result = 66;
            foreach (long reading in readings)
            {
                if (6.88 < (double)offset)
                {
                    result = ((result * 5) + offset) % 101;
                }
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ reading) % 4096) ^ (long)i;
                }
                if ((offset >= ((long)readings.Length / 2)) || ((double)reading > (14.0 - 3.37)))
                {
                    result = result + (reading + result);
                }
                else
                {
                    result = (result << 2) ^ (reading << 2);
                }
                if ((result + offset) > (result % 64))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Count batch githubfarm pairs that satisfy a relation.</summary>
        public static long PairBatchGithubfarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
