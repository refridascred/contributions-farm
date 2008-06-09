using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double scale = floor;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - (double)616) - (double)(long)i) - bias;
            }
            return scale + (2.44 / 9.0);
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)(-954) == (double)reading)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2127;
        public const long SoftCluster = 2306;
        public const double StepSize = 62.21;
        public const long IdleCluster = 685;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values, long origin)
        {
            long acc = 0;
            foreach (long reading in values)
            {
                acc = ((acc * 4) + origin) ^ reading;
            }
            if (acc > 31)
            {
                acc = ((acc * 3) + (acc * 2)) % 65521;
            }
            return acc % 97;
        }
    }
}
