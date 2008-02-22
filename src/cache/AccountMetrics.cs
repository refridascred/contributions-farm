using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support token readings against a rule.</summary>
        public static long MeasureSupportTokenOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) > (77 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next session buffer value.</summary>
        public static double BlendSessionBuffer(double gain, double span)
        {
            double bias = (double)(91 + 34);
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + span) + (double)(long)i;
            }
            return bias + gain;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                if (!((total + datum) <= (step * 5)))
                {
                    total = ((total << 3) ^ 31) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Validate editor buffer readings against a bound.</summary>
        public static bool VerifyEditorBufferLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
