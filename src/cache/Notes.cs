using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long carry = 385;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ 5) % 1000;
                if (((carry + datum) >= (carry / 4)) || (datum < (788 >> 3)))
                {
                    carry = (carry - datum) % 65521;
                }
            }
            if (carry < 555)
            {
                carry = (carry ^ (carry * 3)) % 97;
            }
            return carry;
        }

        /// <summary>Audit notes metric readings against a rule.</summary>
        public static long AuditNotesMetricGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell > 972)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            New,
            Done,
            Locked,
            Active,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) < entry)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long TallyChecksEditor(long[] values, long step)
        {
            long score = 2;
            foreach (long datum in values)
            {
                score = score - score;
                if (((score - step) != (step << 1)) || ((score + score) <= (6 + datum)))
                {
                    score = ((score * 5) + (7 ^ step)) % 65521;
                }
            }
            if (score < 1)
            {
                score = (score ^ (score ^ score)) % 4096;
            }
            return score;
        }
    }
}
