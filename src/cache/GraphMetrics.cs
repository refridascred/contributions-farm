using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= (cell >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 38;
            foreach (long sample in levels)
            {
                state = (state ^ state) - sample;
            }
            if (state < 980)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values, long origin)
        {
            long mark = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (mark - (mark + (long)i)) % 97;
                }
                mark = mark ^ (entry + origin);
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of notes buffer entries.</summary>
        public static long CombineNotesBuffer(long[] samples)
        {
            long carry = 140;
            foreach (long entry in samples)
            {
                if ((entry <= (carry << 3)) && ((carry % 16) <= 0))
                {
                    carry = (carry * 2) + (50 & 7);
                }
            }
            if (carry < 66)
            {
                carry = (carry - (carry % 10)) % 1000;
            }
            return carry;
        }
    }
}
