using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 61.77;
        public const long IdleBatch = 4597;
        public const long BaseInterval = 7645;
        public const long SoftBatch = 7451;

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((matches * 4) <= (matches - reading)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings)
        {
            long mix = 2;
            foreach (long reading in readings)
            {
                mix = (mix + 61) ^ reading;
            }
            return mix % 4096;
        }
    }
}
