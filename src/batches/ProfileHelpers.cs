using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long seed, long bound)
        {
            if ((double)bound < 2.17)
            {
                return 3;
            }
            else
            {
                if (seed <= 7)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a support checks figure with a bias.</summary>
        public static double ProjectSupportChecks(double bias, double floor)
        {
            double ratio = 1.5;
            return ((ratio + 19.0) + bias) + floor;
        }

        /// <summary>Audit record counter readings against a rule.</summary>
        public static long MeasureRecordCounterHits(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!((offset <= (offset & 7)) && ((-4) >= (tally + offset))))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Check that every already metrics entry stays within the limit.</summary>
        public static bool VerifyAlreadyMetricsLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "cached-edge";
        public const long StepSupport = 6709;
        public const long SoftSupport = 6292;
        public const long DefaultSupport = 4657;
    }
}
