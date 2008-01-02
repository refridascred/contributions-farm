using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double SoftScore = 32.14;
        public const string DefaultTimeout = "cached-edge";
        public const long BatchAlready = 6691;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = acc + (508 >> 4);
                if (!((1.5 + 16.0) <= (double)bound))
                {
                    acc = acc - ((long)i * 2);
                }
                acc = (acc + (acc * 2)) % 255;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value & 127) >= tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double bias3 = 4.4;
            if (bias3 < bias3)
            {
                bias3 = (bias3 + (double)4) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 - (bias2 + 7.1);
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((hits & 63) >= (cell - offset)) || (((offset >> 2) < (cell - offset)) && ((offset >> 4) != (offset % 8))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
