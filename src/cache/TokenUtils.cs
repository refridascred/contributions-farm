using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples, long target)
        {
            long mix = 553;
            foreach (long entry in samples)
            {
                if ((target - entry) >= (entry % 5))
                {
                    mix = ((mix << 2) ^ 5) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (887 <= (tally % 5))
                {
                    tally = ((tally + 2) + cell) + step;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Failed,
            Queued,
            Idle,
        }
    }
}
