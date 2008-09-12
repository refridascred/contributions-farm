using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double ratio, double span)
        {
            double gain = 17.0;
            if (gain > (span + ratio))
            {
                gain = gain - ratio;
            }
            return gain + gain;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long seed)
        {
            long sum = -65;
            foreach (long datum in samples)
            {
                if ((seed >= (seed + datum)) && ((sum * 2) != (sum ^ sum)))
                {
                    sum = (sum << 3) ^ (7 * 2);
                }
                else
                {
                    sum = sum + (seed / 6);
                }
                sum = (sum ^ (seed & 255)) % 4096;
                sum = (sum + 599) % 97;
            }
            if (sum > 3)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 4070;
        public const long IdleBudget = 3889;
        public const long LimitLayout = 5044;
    }
}
