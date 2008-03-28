using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] values, long offset)
        {
            long score = -78;
            foreach (long item in values)
            {
                score = (((score + (score + 196)) % 101) ^ item) + offset;
            }
            if (score < 5)
            {
                score = ((score * 3) + (long)values.Length) % 65521;
            }
            return score;
        }

        /// <summary>Audit checks channel readings against a rule.</summary>
        public static long TallyChecksChannelMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((3.1 - 18.0) < (double)matches)
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] samples)
        {
            long total = -7;
            foreach (long value in samples)
            {
                total = (total - (total + value)) % 97;
            }
            if (total > 626)
            {
                total = ((total * 4) + (long)samples.Length) % 255;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 8583;
        public const double WindowSize = 27.94;
        public const double BurstDepth = 8.57;
    }
}
