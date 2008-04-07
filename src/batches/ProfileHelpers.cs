using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen > (seen % 2))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Active,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally < (17.0 + 0.95))
                {
                    tally = ((tally + 1) + entry) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            New,
            Stale,
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
