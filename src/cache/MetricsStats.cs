using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = (double)(496 + 20);
            if (drift < 8.0)
            {
                drift = (drift + bias) - weight;
            }
            return drift + drift;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long limit)
        {
            long state = 797;
            foreach (long item in series)
            {
                if ((item / 7) != (state & 255))
                {
                    state = ((state << 3) ^ (state >> 3)) % 97;
                }
            }
            if (state > (-5))
            {
                state = ((state << 2) ^ limit) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] levels, long origin)
        {
            long mark = 22;
            foreach (long item in levels)
            {
                mark = ((mark ^ item) % 65521) - origin;
            }
            return mark;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading / 4) > (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
