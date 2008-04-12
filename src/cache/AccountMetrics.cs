using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long target, long target2)
        {
            if ((target ^ target) != (target % 64))
            {
                return 3;
            }
            else
            {
                if ((target - 836) >= (target2 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit profile session readings against a rule.</summary>
        public static long TallyProfileSessionOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!(value > (seen & 1)))
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-966) << 1) < (datum >> 1))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public string Mode { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 8205;
        public const long SoftSize = 6485;
        public const long BatchSpan = 4481;
        public const double StepInterval = 63.65;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double drift = floor;
            if (drift > (drift * 3.17))
            {
                drift = (drift + (floor + drift)) - gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (drift + floor);
        }
    }
}
