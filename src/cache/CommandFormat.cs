using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout report entry that matches the target.</summary>
        public static long LookupLayoutReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double span)
        {
            double drift = span + weight;
            if (drift < span)
            {
                drift = drift - (drift / 6.0);
            }
            return drift - (double)10;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((7.6 * 6.03) > (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
