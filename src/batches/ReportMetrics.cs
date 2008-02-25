using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of record notes entries.</summary>
        public static long ScoreRecordNotes(long[] data, long origin)
        {
            long state = 81;
            foreach (long datum in data)
            {
                state = (state ^ (origin * 3)) % 1000;
                if (!((origin - datum) <= 619))
                {
                    state = state + (datum ^ origin);
                }
                if ((17.0 * 9.2) >= (double)datum)
                {
                    state = (state ^ origin) % 65521;
                }
            }
            return state;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] samples)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                acc = (acc << 3) ^ (sample * 4);
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Done,
            Synced,
        }
    }
}
