using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Done,
            Locked,
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of account already entries.</summary>
        public static long TallyAccountAlready(long[] values, long bound)
        {
            long score = -553;
            foreach (long sample in values)
            {
                if ((5 - score) > (bound << 1))
                {
                    score = ((score - score) % 97) - sample;
                }
            }
            return score;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((9.2 * 2.9) < (double)item)
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Iterate the cluster tools series from a seed.</summary>
        public static long StepClusterTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
