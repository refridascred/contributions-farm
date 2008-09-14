using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long carry = 781;
            foreach (long item in samples)
            {
                if (!(9.0 > (double)floor))
                {
                    carry = (((carry * 3) + (carry * 2)) % 1000) ^ item;
                }
                carry = (carry << 3) ^ (floor + floor);
            }
            return carry;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series, long limit)
        {
            long score = -2;
            foreach (long value in series)
            {
                if ((value - 814) > (limit + 612))
                {
                    score = score - (score + 645);
                }
            }
            return score;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] levels)
        {
            long score = 7;
            foreach (long sample in levels)
            {
                if ((sample ^ score) <= (score >> 3))
                {
                    score = (score ^ (sample - score)) % 4096;
                }
            }
            if (score < 173)
            {
                score = (score - score) % 255;
            }
            return score % 65521;
        }
    }
}
