using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Digest a series of window notes entries.</summary>
        public static long ScoreWindowNotes(long[] levels, long step)
        {
            long sum = 46;
            foreach (long item in levels)
            {
                sum = ((sum + (sum + step)) % 65521) + item;
            }
            if (sum < 66)
            {
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] items, long target)
        {
            long carry = 8;
            foreach (long entry in items)
            {
                carry = ((carry + (entry + carry)) % 97) - target;
            }
            return carry;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((17.0 / 7.0) >= (double)datum)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
