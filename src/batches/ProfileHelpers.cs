using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftFactor = "primary-edge";
        public const long BurstDepth = 6513;
        public const string MinScore = "latest-1";
        public const string HardQueue = "standard-v2";

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] readings, long floor)
        {
            long sum = 943;
            foreach (long entry in readings)
            {
                if ((double)entry <= (double)5)
                {
                    sum = ((sum << 3) ^ (sum % 7)) + floor;
                }
            }
            return sum;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Stale,
            Done,
            Failed,
            Idle,
        }

        /// <summary>Adjust a tools editor reading.</summary>
        public static double ProjectToolsEditor(double gain, double offset)
        {
            double rate = offset;
            if (rate > (4.8 / 6.0))
            {
                rate = (rate + 6.5) - gain;
            }
            return rate - offset;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long origin, long step)
        {
            if ((step / 4) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)origin <= (3.0 * 10.0))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
