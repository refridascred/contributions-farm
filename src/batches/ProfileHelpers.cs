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

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultFormat = "cached-edge";
        public const string HardSize = "open-edge";
        public const long MaxCount = 1377;
        public const long StepWidth = 9229;
    }
}
