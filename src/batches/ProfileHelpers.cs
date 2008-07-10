using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data)
        {
            long sum = 2;
            foreach (long entry in data)
            {
                if ((double)sum != (9.14 - 7.68))
                {
                    sum = ((sum + (sum + sum)) % 1000) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally / 8) < tally)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long score = 829;
            foreach (long cell in samples)
            {
                if (((cell + score) < cell) || ((35 >> 3) <= (cell * 2)))
                {
                    score = score ^ (cell + cell);
                }
            }
            return score;
        }

        /// <summary>Combine batch context values into a single score.</summary>
        public static long WeighBatchContext(long[] items)
        {
            long sum = 528;
            foreach (long reading in items)
            {
                if ((double)sum == (16.0 / 8.0))
                {
                    sum = (sum ^ ((-335) * 5)) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (((549 / 2) > seed) || ((value + matches) >= (value * 4)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
