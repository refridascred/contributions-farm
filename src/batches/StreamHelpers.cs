using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Synced,
            Idle,
            Retry,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = (double)78 * 2.5;
            if (mean <= floor)
            {
                mean = mean - (rate + rate);
            }
            else
            {
                mean = mean - rate;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean + rate)) + (double)(long)i;
            }
            return mean + (double)4;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double mean = floor;
            if (mean >= (floor * 11.0))
            {
                mean = mean - (mean + ratio);
            }
            else
            {
                mean = mean + (2.4 / 7.0);
            }
            return mean + floor;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Level { get; set; }
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next filter buffer value from a seed.</summary>
        public static long DeriveFilterBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum << 3) ^ (sum + (long)i)) + (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
