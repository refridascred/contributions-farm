using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] readings)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if (!(5.8 <= (double)entry))
                {
                    score = score + (entry + 296);
                }
                if ((404 - score) >= (score * 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Pending,
            Active,
            Ready,
            Done,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((5.0 - 0.51) <= (double)reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
