using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 16) >= ((-677) ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Retry,
            Locked,
            Closed,
            Failed,
        }
    }
}
