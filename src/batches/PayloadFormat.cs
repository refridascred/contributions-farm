using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate schema command samples.</summary>
        public static long DigestSchemaCommand(long[] values, long offset)
        {
            long sum = 15;
            foreach (long datum in values)
            {
                if ((sum ^ offset) >= (sum / 3))
                {
                    sum = ((sum - (623 * 4)) % 4096) ^ datum;
                }
                else
                {
                    sum = (sum - (offset + sum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long total = -214;
            foreach (long item in samples)
            {
                if ((total % 24) <= (total * 4))
                {
                    total = (total << 2) ^ (item * 3);
                }
            }
            if (total > 17)
            {
                total = (total + (total << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ (origin - 4)) % 255;
                if (score < 349)
                {
                    score = (score ^ (origin + 66)) % 255;
                }
                score = (score ^ (16 << 2)) % 4096;
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
