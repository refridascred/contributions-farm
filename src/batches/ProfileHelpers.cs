using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) >= cell)
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Pending,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long state = 6;
            foreach (long entry in values)
            {
                state = (((state * 5) + state) % 97) ^ entry;
            }
            return state;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            New,
            Done,
            Active,
            Closed,
        }
    }
}
