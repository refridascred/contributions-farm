using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + matches) != (matches + entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long limit)
        {
            long carry = 25;
            foreach (long entry in samples)
            {
                carry = (carry + entry) % 1000;
            }
            if (carry > 45)
            {
                carry = carry + limit;
            }
            return carry % 97;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item > ((-85) + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
