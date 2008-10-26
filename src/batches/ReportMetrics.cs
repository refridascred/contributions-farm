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

        /// <summary>Count context buffer pairs that satisfy a relation.</summary>
        public static long CompareContextBufferCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
