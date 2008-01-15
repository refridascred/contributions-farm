using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (floor < seen)
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetrySpan = 5063;
        public const double SoftReport = 98.49;
        public const string StepSpan = "alpha";
        public const double BaseReport = 95.07;

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = 403;
            foreach (long reading in readings)
            {
                mix = (mix ^ 2) % 97;
                if ((double)reading == (9.8 - 10.0))
                {
                    mix = ((mix << 2) ^ (reading % 2)) % 101;
                }
                else
                {
                    mix = ((mix * 4) + (reading - reading)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Limit { get; set; }
            public double Mode { get; set; }
        }
    }
}
