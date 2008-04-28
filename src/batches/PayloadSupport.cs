using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long SeriesSupportGraph(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ ((long)i / 7)) % 65521;
                result = (result ^ (long)i) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the graph tools entries that pass the check.</summary>
        public static long TallyGraphToolsMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)seen > (16.0 / 7.0))
                {
                    seen = ((seen + 1) ^ reading) + origin;
                }
            }
            return seen;
        }
    }
}
