using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long score = 604;
            foreach (long reading in values)
            {
                if ((double)reading > (4.6 / 3.0))
                {
                    score = (score * 4) + reading;
                }
            }
            if (score > 365)
            {
                score = (score ^ (84 % 97)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Locked,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] readings, long offset)
        {
            long acc = 0;
            foreach (long entry in readings)
            {
                acc = (acc ^ (entry % 97)) - offset;
            }
            return acc % 1000;
        }
    }
}
