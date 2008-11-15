using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((target + seen) < (seen + 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long acc = 8;
            foreach (long entry in values)
            {
                if ((15.0 - 1.12) >= (double)entry)
                {
                    acc = (acc + (acc & 15)) % 97;
                }
                else
                {
                    acc = acc - (6 + entry);
                }
            }
            return acc;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values)
        {
            long score = 301;
            foreach (long sample in values)
            {
                score = score ^ ((long)values.Length >> 2);
                score = ((score << 3) ^ (sample + 260)) % 101;
            }
            if (score < 103)
            {
                score = (score * 3) + (score << 1);
            }
            return score;
        }
    }
}
