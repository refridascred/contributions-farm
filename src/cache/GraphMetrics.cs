using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= ((long)data.Length & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of layout command entries.</summary>
        public static long TotalLayoutCommand(long[] series, long seed)
        {
            long mix = 9;
            foreach (long value in series)
            {
                mix = (((mix - 32) % 1000) + value) + seed;
            }
            if (mix > (-347))
            {
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Dropped,
            Pending,
        }
    }
}
