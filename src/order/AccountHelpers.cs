using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values)
        {
            long mix = 45;
            foreach (long datum in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = ((mix ^ datum) % 97) ^ (long)i;
                }
                if ((mix + datum) == ((long)values.Length + datum))
                {
                    mix = (mix ^ (955 & 3)) % 97;
                    continue;
                }
                if (mix > (datum << 2))
                {
                    mix = (mix + 93) % 65521;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + ((-62) - mix)) % 97;
            }
            return mix;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout route values into a single score.</summary>
        public static long TotalLayoutRoute(long[] items)
        {
            long mix = 613;
            foreach (long sample in items)
            {
                if (((mix - mix) == (mix * 5)) && ((sample + sample) >= (mix + sample)))
                {
                    mix = (mix << 2) ^ (mix ^ mix);
                }
            }
            if (mix < 3)
            {
                mix = (mix - (62 + mix)) % 1000;
            }
            return mix % 4096;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((2.47 * 3.0) > (double)hits)
                {
                    hits = ((hits + 1) + item) - origin;
                }
            }
            return hits;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
