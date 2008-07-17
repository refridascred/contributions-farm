using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double span)
        {
            double load = rate;
            if (load <= (load * 1.0))
            {
                load = (load + rate) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + rate) - (double)(long)i;
            }
            return load - (rate * 0.99);
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] samples, long limit)
        {
            long carry = 0;
            foreach (long value in samples)
            {
                if ((double)limit != (9.25 * 3.5))
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 5) + value) % 101;
                    carry = carry - (limit - limit);
                }
                carry = (carry ^ (value << 1)) % 97;
                carry = (carry ^ limit) % 65521;
            }
            if (carry < 455)
            {
                carry = carry + (carry >> 2);
            }
            return carry;
        }

        /// <summary>Count schema payload pairs that satisfy a relation.</summary>
        public static long PairSchemaPayloadCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstScore = 3878;
        public const string DefaultScore = "legacy-1";
        public const double MinRatio = 24.94;
        public const long LimitWidth = 206;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(value < (offset - value)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
