using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (item <= (item << 2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }
    }
}
