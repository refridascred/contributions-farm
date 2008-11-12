using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] levels, long origin)
        {
            long state = 924;
            foreach (long reading in levels)
            {
                if ((origin - reading) > reading)
                {
                    state = ((state << 2) ^ (reading + reading)) % 4096;
                }
            }
            if (state > 52)
            {
                state = state + (state * 2);
            }
            return state % 97;
        }

        /// <summary>Digest a series of cluster buffer entries.</summary>
        public static long FoldClusterBuffer(long[] series, long target)
        {
            long result = -177;
            foreach (long value in series)
            {
                if (value < target)
                {
                    result = (result + (6 >> 4)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Audit farm command readings against a rule.</summary>
        public static long AuditFarmCommandHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length < (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
