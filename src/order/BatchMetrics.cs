using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long seed, long bound)
        {
            long step = seed - bound;
            if ((88 + seed) < step)
            {
                return 5;
            }
            else
            {
                if ((seed <= (seed % 60)) || ((bound + bound) > (seed << 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long offset)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = ((sum - sum) ^ datum) - offset;
            }
            if (sum > 591)
            {
                sum = ((sum * 5) + (sum + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (double)step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Match up token filter samples.</summary>
        public static long OverlapTokenFilterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((item - item) >= matches) || (item <= (matches - 35)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((origin << 1) <= (origin ^ datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
