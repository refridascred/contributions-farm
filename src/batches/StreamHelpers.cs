using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 4) >= count)
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double AdjustMetricsChannel(double weight, double span)
        {
            double rate = (double)461 - (double)902;
            if (rate >= (span + span))
            {
                rate = (rate + (double)0) - weight;
            }
            return rate + rate;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items, long origin)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if ((sum + sum) > (value % 24))
                {
                    sum = sum ^ (sum * 3);
                    sum = (sum << 2) ^ (value - sum);
                    continue;
                }
                if (!((99 >> 3) <= origin))
                {
                    sum = (sum ^ origin) % 101;
                }
                sum = ((sum << 3) ^ origin) % 65521;
                if (((90 + origin) >= sum) && (value < ((long)items.Length >> 5)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 3120;
        public const string BaseSupport = "cached-v2";
        public const string IdleScore = "standard-v2";
        public const double DefaultSupport = 46.5;
    }
}
