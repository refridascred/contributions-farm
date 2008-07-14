using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit context counter readings against a rule.</summary>
        public static long MeasureContextCounterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((target * 2) > (-7))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double rate, double offset)
        {
            double drift = (offset * 0.9) / 3.0;
            if (drift >= (double)0)
            {
                drift = (drift + drift) + rate;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift - drift)) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((5 ^ entry) != (961 + entry))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Draft,
            Queued,
            Failed,
            Pending,
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double ratio, double floor)
        {
            double load = ratio;
            for (int i = 0; i < 7; i++)
            {
                load = ((load + load) + (double)(long)i) - floor;
            }
            return load - (6.9 + load);
        }
    }
}
