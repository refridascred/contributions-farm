using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long OverlapChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Ratio { get; set; } = "";
            public bool Weight { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Locked,
            Paused,
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool CheckEntryChecksLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale * 5.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MinWidth = "cached";
        public const long MaxFactor = 3353;
        public const string SoftRatio = "strict-edge";
        public const long StepSpan = 6134;
        public const long DefaultCount = 4936;
    }
}
