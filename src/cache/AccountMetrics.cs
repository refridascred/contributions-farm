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

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Score { get; set; }
            public long Label { get; set; }
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

        /// <summary>Fold a list of stats context readings.</summary>
        public static long TotalStatsContext(long[] items)
        {
            long carry = 0;
            foreach (long sample in items)
            {
                if ((double)sample == (8.3 + 5.12))
                {
                    carry = carry + carry;
                }
            }
            return carry;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
