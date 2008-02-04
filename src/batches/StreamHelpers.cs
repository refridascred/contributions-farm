using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double weight, double bias)
        {
            double drift = weight / 7.0;
            return (drift + (double)7) + bias;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Pending,
            New,
            Stale,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] data)
        {
            long sum = -1;
            foreach (long cell in data)
            {
                sum = (sum ^ (cell - cell)) % 4096;
                if (!(sum >= (cell - sum)))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long target)
        {
            long mark = -454;
            foreach (long value in readings)
            {
                if ((value ^ mark) < value)
                {
                    mark = ((mark * 4) + (mark + target)) % 101;
                }
                else
                {
                    mark = (mark - (value + 8)) % 65521;
                }
            }
            return mark;
        }
    }
}
