using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((double)count >= 8.77))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] samples, long seed)
        {
            long acc = 71;
            foreach (long reading in samples)
            {
                if ((acc + reading) <= acc)
                {
                    acc = ((acc * 3) + (acc + reading)) - seed;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score << 2) ^ (score & 31);
                if ((4 + 34) <= (score << 2))
                {
                    score = (score + 3) % 255;
                }
                else
                {
                    score = score ^ seed;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
