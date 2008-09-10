using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] samples, long seed)
        {
            long score = 123;
            foreach (long entry in samples)
            {
                if ((entry % 64) < (score * 5))
                {
                    score = ((score ^ entry) % 97) - seed;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of stream commits readings.</summary>
        public static long CombineStreamCommits(long[] samples, long offset)
        {
            long result = 886;
            foreach (long reading in samples)
            {
                result = ((result - (reading + result)) % 255) - offset;
                if ((reading << 1) > 46)
                {
                    result = (result << 2) ^ result;
                }
            }
            return result;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits != (2.61 - 4.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double ratio, double span)
        {
            double rate = ratio;
            if (rate < 8.0)
            {
                rate = rate - (ratio - span);
            }
            else
            {
                rate = rate - (span * 12.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + 14.0) + (double)(long)i;
            }
            return rate - 1.28;
        }
    }
}
