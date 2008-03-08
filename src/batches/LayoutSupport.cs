using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Ready,
            Closed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 4565;
        public const string MaxWidth = "legacy-1";
        public const long IdleSize = 5098;

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double SmoothBatch(double weight, double floor)
        {
            double mean = (double)((-124) + 6);
            if (mean >= (double)40)
            {
                mean = mean - (weight / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (floor + 7.7)) - (double)(long)i;
            }
            return mean + 18.0;
        }
    }
}
