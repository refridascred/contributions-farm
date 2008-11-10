using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            if ((double)2 == (double)bound)
            {
                return 8;
            }
            else
            {
                if (((double)limit != (13.0 + 5.5)) && (((-619) >> 1) > (6 + limit)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result << 3)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (seen + datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
