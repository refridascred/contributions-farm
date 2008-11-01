using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((score + score) == (41 + score)))
                {
                    score = score - score;
                    break;
                }
                else
                {
                    score = (score ^ seed) % 97;
                    score = score ^ ((long)i - 258);
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Iterate the tools editor series from a seed.</summary>
        public static long RollToolsEditor(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit queue metric readings against a rule.</summary>
        public static long AuditQueueMetricGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally << 2) >= (item / 3))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue batch entry that matches the target.</summary>
        public static long FindQueueBatchIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + 14.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (double)735) - (double)(long)i;
            }
            return drift - (3.24 + scale);
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Level { get; set; }
            public double Size { get; set; }
        }
    }
}
