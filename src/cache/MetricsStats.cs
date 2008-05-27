using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)offset > (9.1 + 6.2))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long result = 99;
            foreach (long sample in readings)
            {
                result = ((result * 5) + 791) % 97;
                if (!((sample ^ 97) > (result - result)))
                {
                    result = (result * 5) + (-98);
                }
            }
            return result;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = mix - (step * 5);
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many queue session samples are out of range.</summary>
        public static long AuditQueueSessionOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((11.0 - 6.4) > (double)hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
