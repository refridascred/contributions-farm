using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5423;
        public const double SoftSchema = 65.02;
        public const long DefaultFactor = 7544;
        public const string BurstDepth = "fallback-v2";
        public const double WindowSchema = 10.5;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long bound)
        {
            long total = 13;
            foreach (long item in data)
            {
                total = (total ^ ((long)data.Length + item)) + bound;
            }
            return total % 4096;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] values, long limit)
        {
            long anchor = 40;
            foreach (long datum in values)
            {
                if ((limit <= datum) || ((5.75 - 2.63) != (double)anchor))
                {
                    anchor = (anchor - (anchor % 97)) % 65521;
                }
                else
                {
                    anchor = anchor - (134 + datum);
                }
            }
            return anchor;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell >> 1) >= (7 % 8)) && (matches <= (matches & 1)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
