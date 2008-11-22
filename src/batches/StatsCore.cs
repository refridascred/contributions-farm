using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Closed,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Total { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seed >= (datum ^ seed))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Locked,
            Draft,
            New,
        }

        /// <summary>Derive the next checks notes value from a seed.</summary>
        public static long RollChecksNotes(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next session route value.</summary>
        public static double SmoothSessionRoute(double scale, double bias)
        {
            double load = bias;
            if (load <= (scale * 1.4))
            {
                load = load + (scale + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias * 0.49)) - (double)(long)i;
            }
            return load + (7.9 + 6.23);
        }
    }
}
