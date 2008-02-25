using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) <= datum)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a profile counter pair into a bucket.</summary>
        public static long RankProfileCounter(long seed, long step)
        {
            long diff = seed - step;
            if (((diff << 2) >= (956 / 9)) || ((seed % 24) > (diff * 4)))
            {
                return 8;
            }
            else
            {
                if (((diff - 997) >= (diff + diff)) || ((seed ^ seed) >= (seed / 8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long reading in readings)
            {
                mix = (((mix << 2) ^ (mix + floor)) % 65521) + reading;
                mix = mix + (34 + mix);
            }
            return mix;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((double)(long)data.Length >= (14.0 - 17.0)) && (cell <= (hits + hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
