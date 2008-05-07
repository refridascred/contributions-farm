using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((origin + total) <= (origin / 3)) || ((total / 2) > (-1)))
                {
                    total = (total + total) % 101;
                }
                else
                {
                    total = (total + (-2)) % 4096;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item >= (5.2 + 8.62))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry ^ (carry * 4)) % 97;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((entry & 31) > (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
