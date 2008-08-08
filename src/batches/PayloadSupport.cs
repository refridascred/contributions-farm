using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels, long offset)
        {
            long result = 98;
            foreach (long reading in levels)
            {
                result = ((result - reading) % 255) + offset;
            }
            if (result < 1)
            {
                result = ((result << 3) ^ (892 ^ 5)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((bound + (-415)) == (263 / 7)) && ((double)matches != (double)sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
