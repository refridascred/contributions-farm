using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of report support readings.</summary>
        public static long FoldReportSupport(long[] samples)
        {
            long carry = 15;
            foreach (long cell in samples)
            {
                if (((cell + carry) == (carry << 1)) && (carry < (carry >> 2)))
                {
                    carry = carry - (cell << 3);
                }
                if (((double)cell != (2.2 / 4.0)) || ((cell + cell) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Measure how many profile buffer samples are out of range.</summary>
        public static long TallyProfileBufferGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((-615) >> 2) <= (seen * 2))
                {
                    seen = (seen + 2) - cell;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long origin)
        {
            if ((origin / 7) < (step / 8))
            {
                return 3;
            }
            else
            {
                if (4 <= (step << 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin < (84 + 4)) || (899 > ((-62) - origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
