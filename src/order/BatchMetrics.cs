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

        /// <summary>Find the first record metrics entry that matches the target.</summary>
        public static long LocateRecordMetricsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = (score + (long)i) % 1000;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
