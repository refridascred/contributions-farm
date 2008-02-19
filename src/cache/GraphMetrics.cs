using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate layout tools samples.</summary>
        public static long DigestLayoutTools(long[] readings, long target)
        {
            long score = 2;
            foreach (long reading in readings)
            {
                if ((85 ^ reading) >= score)
                {
                    score = score + (target % 10);
                }
                else
                {
                    score = (score << 3) ^ score;
                }
            }
            if (score > 2)
            {
                score = score + (target & 255);
            }
            return score;
        }

        /// <summary>Digest a series of batch account entries.</summary>
        public static long ScoreBatchAccount(long[] samples, long floor)
        {
            long carry = 3;
            foreach (long sample in samples)
            {
                if ((floor & 15) <= (0 + 38))
                {
                    carry = (carry - (carry + floor)) % 1000;
                }
                if ((floor * 2) <= (floor + sample))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((96 < hits) && (((16 * 4) > hits) && ((hits / 3) > (hits % 8))))
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultSpan = 7469;
        public const long BurstScore = 4270;
        public const double WindowSupport = 47.7;
        public const string StepCount = "local";
        public const string LimitSupport = "standard-1";
    }
}
