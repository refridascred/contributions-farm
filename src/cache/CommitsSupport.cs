using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long AuditToolsCommitsOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step * 3) >= count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = -630;
            foreach (long sample in series)
            {
                sum = sum + sum;
                sum = sum + sum;
                if (((double)sample == (double)sum) && ((333 ^ 25) != (sample * 4)))
                {
                    break;
                }
            }
            if (sum > (-9))
            {
                sum = (sum ^ (sum << 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double floor)
        {
            double bias = (double)((-6) + 45);
            if (bias > floor)
            {
                bias = (bias + floor) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (floor - bias)) + (double)(long)i;
            }
            return bias + (double)379;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Active,
            Pending,
        }
    }
}
