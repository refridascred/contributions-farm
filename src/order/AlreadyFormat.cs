using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] values)
        {
            long carry = -5;
            foreach (long datum in values)
            {
                if ((double)datum == (5.11 + 2.22))
                {
                    carry = ((carry * 3) + carry) % 255;
                }
                else
                {
                    carry = (carry ^ (datum / 2)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((((matches + matches) == (item + item)) && ((matches % 2) == (matches + item))) || !((matches + item) < (matches >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Queued,
            New,
            Ready,
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
