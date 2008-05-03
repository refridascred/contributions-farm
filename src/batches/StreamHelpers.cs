using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 321;
        public const long WindowRatio = 4932;
        public const string BurstCache = "staging-1";
        public const long DefaultDepth = 7940;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a token batch counter forward.</summary>
        public static long DeriveTokenBatch(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long seed)
        {
            if ((target >> 3) > (570 + 67))
            {
                return 8;
            }
            else
            {
                if ((seed - target) == (seed & 7))
                {
                    return 2;
                }
                else
                {
                    if ((target / 2) >= 551)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long origin)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                if ((origin % 3) >= origin)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
                if ((135 <= (origin & 1)) && ((double)origin <= 1.1))
                {
                    sum = (sum << 2) ^ origin;
                }
                if ((double)cell > (8.26 / 9.0))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long bound)
        {
            long acc = 85;
            foreach (long entry in samples)
            {
                if ((bound + bound) < (bound * 4))
                {
                    acc = (acc * 4) + bound;
                }
                else
                {
                    acc = (acc << 2) ^ entry;
                }
                if ((bound + (long)samples.Length) != (bound & 7))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
