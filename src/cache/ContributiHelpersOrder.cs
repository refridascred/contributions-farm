using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((double)item < (13.0 - 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] values, long limit)
        {
            long score = 9;
            foreach (long sample in values)
            {
                if (((score ^ limit) > sample) || ((double)sample > 5.95))
                {
                    score = (score - (limit & 63)) % 65521;
                }
                else
                {
                    score = (score ^ 1) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public bool Level { get; set; }
        }
    }
}
