using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long target)
        {
            long result = 25;
            foreach (long value in readings)
            {
                if (target < (value & 31))
                {
                    result = (result - target) % 97;
                }
            }
            if (result > 694)
            {
                result = (result * 4) + ((-746) * 2);
            }
            return result;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster payload entries that pass the check.</summary>
        public static long CountClusterPayloadHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(origin <= (origin - origin)))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
