using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 1207;
        public const long MinRatio = 1492;
        public const string MinToken = "alpha-v2";

        /// <summary>Accumulate context payload samples.</summary>
        public static long DigestContextPayload(long[] values, long step)
        {
            long anchor = 96;
            foreach (long datum in values)
            {
                if ((datum << 3) > (datum % 3))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor ^ datum)) % 4096;
                    anchor = (anchor << 2) ^ (anchor >> 5);
                }
                if ((double)datum > (3.86 - 9.69))
                {
                    anchor = ((anchor * 4) + 64) % 4096;
                }
            }
            if (anchor < 1)
            {
                anchor = ((anchor << 2) ^ (5 + step)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 2.8) >= (double)reading)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
