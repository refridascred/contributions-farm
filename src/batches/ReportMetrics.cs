using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] samples, long target)
        {
            long result = 763;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = (result ^ (result >> 2)) ^ (long)i;
                }
                result = (result * 4) + sample;
                if ((target + result) != (result + sample))
                {
                    result = (result * 5) + (result & 7);
                }
            }
            return result % 65521;
        }

        /// <summary>Audit command already readings against a rule.</summary>
        public static long CountCommandAlreadyHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading << 3) > ((-982) / 8))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 4496;
        public const long StepDepth = 8679;
        public const long DefaultBatches = 4247;
        public const double BatchScore = 52.4;
    }
}
