using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 650;
            foreach (long cell in items)
            {
                if (((cell << 3) < (cell % 12)) && ((double)carry > 9.6))
                {
                    carry = (carry + (carry + cell)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
                if (((double)cell >= 10.0) && ((carry / 4) >= (cell - cell)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 8; i++)
            {
                rate2 = ((rate2 + rate) + (double)(long)i) - span;
            }
            return rate2 + rate2;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 2570;
        public const double BurstGraph = 82.21;
        public const long BatchGraph = 4510;
        public const long IdleGraph = 2966;

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (anchor > (anchor / 7))
                {
                    anchor = anchor + (long)i;
                    anchor = (anchor + (floor / 3)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
