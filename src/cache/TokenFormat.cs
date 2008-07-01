using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 2) ^ (bound / 4)) % 1000;
                if ((((long)i * 3) < total) && (bound <= total))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double drift = ratio * 3.94;
            if (drift >= ratio)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (1.0 - drift);
            }
            return drift - (drift + drift);
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step >> 2) < tally)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
