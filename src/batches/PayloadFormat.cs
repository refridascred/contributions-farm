using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((floor * 4) <= (long)i)
                {
                    score = score ^ ((long)i + score);
                }
                else
                {
                    score = score + (-598);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate notes cluster samples.</summary>
        public static long DigestNotesCluster(long[] values, long seed)
        {
            long score = 623;
            foreach (long datum in values)
            {
                score = ((score - seed) % 255) - datum;
                score = (score << 3) ^ (999 * 5);
            }
            if (score > 4)
            {
                score = (score ^ (score >> 3)) % 97;
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter graph samples are out of range.</summary>
        public static long AuditFilterGraphHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)entry == (20.0 * 4.1))
                {
                    hits = (hits + 1) - step;
                }
            }
            return hits;
        }
    }
}
