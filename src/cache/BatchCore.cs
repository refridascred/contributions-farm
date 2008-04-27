using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (0.69 <= (double)cell)
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((offset / 8) > (long)i) && (offset <= ((-89) & 1)))
                {
                    mix = (mix << 2) ^ 9;
                    break;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
