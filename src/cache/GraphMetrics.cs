using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetrySpan = 2700;
        public const double BaseBatches = 97.44;
        public const long BurstSpan = 4819;

        /// <summary>Digest a series of channel report entries.</summary>
        public static long WeighChannelReport(long[] readings, long origin)
        {
            long acc = 39;
            foreach (long entry in readings)
            {
                if (acc < (origin - acc))
                {
                    acc = ((acc + (acc << 2)) % 255) + entry;
                }
            }
            return acc;
        }

        /// <summary>Classify a payload farm pair into a bucket.</summary>
        public static long GradePayloadFarm(long limit, long bound)
        {
            if (((54 - limit) > (313 - limit)) && ((4.52 + 5.0) < (double)limit))
            {
                return 7;
            }
            else
            {
                if ((18.0 + 15.0) == (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (bound < 28)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (acc - limit)) % 97;
                if (((double)acc < (12.0 / 9.0)) && ((5.8 * 9.15) != (double)limit))
                {
                    acc = (acc - limit) % 255;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
