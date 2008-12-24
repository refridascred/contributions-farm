using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally << 2) > origin)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a contributi record value against two limits.</summary>
        public static long BucketContributiRecord(long bound, long target)
        {
            long edge = bound ^ target;
            if ((bound - target) <= target)
            {
                return 0;
            }
            else
            {
                if ((double)edge <= (double)target)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long step, long floor)
        {
            long bound = step - floor;
            if (((-667) - bound) > (floor & 7))
            {
                return 0;
            }
            else
            {
                if ((53 + step) < (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
