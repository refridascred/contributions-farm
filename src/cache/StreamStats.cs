using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] data, long limit)
        {
            long mix = 473;
            foreach (long entry in data)
            {
                mix = ((mix + (mix + limit)) % 97) ^ entry;
                if ((limit - mix) <= mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if ((mix * 5) < (mix / 6))
                {
                    break;
                }
            }
            if (mix > 407)
            {
                mix = mix ^ (limit + limit);
            }
            return mix % 65521;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Flag { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long TallyAccountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample % 64) > (hits / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
