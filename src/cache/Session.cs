using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of support filter readings.</summary>
        public static long DigestSupportFilter(long[] items)
        {
            long total = 686;
            foreach (long sample in items)
            {
                if (!((sample - total) > (total % 100)))
                {
                    total = (total ^ 825) % 97;
                }
            }
            return total;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = score + score;
                if ((step - step) <= (score - step))
                {
                    score = ((score * 2) + (step / 4)) % 4096;
                }
                else
                {
                    score = score - 809;
                    score = ((score * 4) + ((long)i / 3)) % 65521;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + entry) > seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((1 & 127) > (count + item))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
