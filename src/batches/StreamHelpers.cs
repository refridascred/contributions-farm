using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double offset)
        {
            double drift = offset * 20.0;
            if (drift > ratio)
            {
                drift = drift - (ratio / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (offset < (22 + matches))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepSpan = 52.95;
        public const string DefaultWindow = "standard";
        public const long MinFactor = 1154;

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((double)matches > 5.42) || ((sample << 2) < (matches - 282))) || ((sample % 60) < 57))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepFactor = 1901;
        public const string LimitLayout = "local-edge";
        public const long RetryCount = 8879;
    }
}
