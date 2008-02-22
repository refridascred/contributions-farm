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

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long RankStream(long floor, long bound)
        {
            if ((bound + (-126)) == (bound >> 4))
            {
                return 2;
            }
            else
            {
                if ((floor % 10) == (floor / 8))
                {
                    return 8;
                }
                else
                {
                    if ((bound + floor) > (bound & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)floor > 8.38))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
