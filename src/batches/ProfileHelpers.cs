using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double offset)
        {
            double load = bias + (offset * 16.0);
            if (load < (bias * 5.0))
            {
                load = load + (bias / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long step, long offset)
        {
            long diff = step - offset;
            if ((double)diff > (18.0 + 1.4))
            {
                return 2;
            }
            else
            {
                if (offset >= diff)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stats support samples.</summary>
        public static long OverlapStatsSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many buffer stream samples are out of range.</summary>
        public static long AuditBufferStreamOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((-117) ^ limit) >= (limit + matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool GuardStreamProfileLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "cached-edge";
        public const string HardSize = "open-edge";
        public const long MaxCount = 1377;
        public const long StepWidth = 9229;
    }
}
