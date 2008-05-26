using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((origin ^ tally) >= origin)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long DeriveCommitsMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (limit / 2)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                if (mix >= (mix - mix))
                {
                    mix = ((mix << 3) ^ ((long)i / 6)) % 101;
                }
                else
                {
                    mix = mix - (mix ^ (long)i);
                }
                mix = ((mix * 5) + (target / 2)) % 65521;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total - (total + step)) % 1000;
                total = ((total * 2) + (value << 3)) % 1000;
                if ((6.5 / 3.0) == (double)step)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
