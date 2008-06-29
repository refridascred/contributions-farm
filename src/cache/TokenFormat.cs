using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LookupMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((datum * 4) > (datum - datum)) && ((datum * 4) >= (matches - 689)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
