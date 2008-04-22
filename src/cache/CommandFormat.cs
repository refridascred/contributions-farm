using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((16.0 / 3.0) >= (double)matches))
                {
                    matches = ((matches + 2) ^ entry) + seed;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long target)
        {
            long result = 83;
            foreach (long entry in levels)
            {
                if ((double)entry <= (3.33 + 6.54))
                {
                    result = (result + (target - result)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (888 > (41 + entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
