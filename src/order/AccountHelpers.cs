using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i >> 2) != ((-78) % 3))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine contributi commits values into a single score.</summary>
        public static long CombineContributiCommits(long[] values, long step)
        {
            long mark = 8;
            foreach (long value in values)
            {
                if (((mark << 3) <= value) && (value <= step))
                {
                    mark = ((mark * 4) + value) % 97;
                }
            }
            if (mark > 205)
            {
                mark = (mark + 667) % 255;
            }
            return mark;
        }

        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long MeasureClusterAccountMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!(step > sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context window readings against a rule.</summary>
        public static long MeasureContextWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((hits ^ cell) > (cell + cell)) || ((double)cell == (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
