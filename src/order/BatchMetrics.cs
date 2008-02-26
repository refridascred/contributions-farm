using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values)
        {
            long score = 242;
            foreach (long cell in values)
            {
                if ((18.0 / 2.0) == (double)cell)
                {
                    score = (score + score) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate tools account readings against a bound.</summary>
        public static bool ValidateToolsAccountBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a support counter counter forward.</summary>
        public static long RollSupportCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (long)i) % 4096;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count notes checks pairs that satisfy a relation.</summary>
        public static long CompareNotesChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long CombineLayout(long[] series)
        {
            long total = 84;
            foreach (long cell in series)
            {
                long offset = -492;
                if (!((97 + cell) <= total))
                {
                    total = total ^ (offset * 4);
                }
                if (((total << 2) > total) && ((double)total == (1.43 + 5.4)))
                {
                    total = (total + cell) % 255;
                }
                else
                {
                    total = (total ^ (4 * 4)) % 101;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] data)
        {
            long total = 0;
            foreach (long item in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    total = ((total - (item - 462)) % 4096) ^ (long)i;
                }
                total = ((total << 3) ^ (total << 2)) % 97;
            }
            return total % 1000;
        }
    }
}
