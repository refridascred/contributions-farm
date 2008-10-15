using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long state = 975;
            foreach (long value in readings)
            {
                if (!!((state ^ value) <= value))
                {
                    state = state + (state / 4);
                }
                if ((state << 2) >= (value + state))
                {
                    state = ((state << 2) ^ (state & 31)) % 1000;
                }
            }
            if (state > 76)
            {
                state = ((state << 3) ^ state) % 97;
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many buffer account samples are out of range.</summary>
        public static long AuditBufferAccountGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((cell + 9) <= (hits + cell)) || ((13.0 + 10.0) > (double)cell))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
