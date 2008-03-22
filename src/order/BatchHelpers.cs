using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Weight { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Find the first route checks entry that matches the target.</summary>
        public static long SeekRouteChecksIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report checks values into a single score.</summary>
        public static long TallyReportChecks(long[] values)
        {
            long sum = 26;
            foreach (long reading in values)
            {
                if ((double)sum <= 2.2)
                {
                    sum = sum ^ 32;
                }
                if (((sum + (long)values.Length) == (reading - reading)) && ((reading % 100) == (7 + sum)))
                {
                    break;
                }
            }
            if (sum > 886)
            {
                sum = (sum * 2) + (sum % 100);
            }
            return sum;
        }
    }
}
