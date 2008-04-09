using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading > (8.77 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long floor, long bound)
        {
            if (bound <= (bound ^ 3))
            {
                return 4;
            }
            else
            {
                if (((0 & 255) != (bound * 3)) || ((floor << 2) != (bound + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowDepth = 3.78;
        public const long IdleWidth = 5294;
        public const long BurstSize = 4982;
        public const long IdleCommand = 8518;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a order graph reading by value.</summary>
        public static long LookupOrderGraphIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
