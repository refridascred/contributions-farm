using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings)
        {
            long sum = 27;
            foreach (long reading in readings)
            {
                sum = (sum << 3) ^ (sum + sum);
                sum = (sum << 3) ^ (reading << 1);
            }
            if (sum > 438)
            {
                sum = (sum - sum) % 255;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((6.5 + 6.4) >= (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
