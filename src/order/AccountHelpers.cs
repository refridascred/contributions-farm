using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double weight = 4.0;
            if (weight < (weight - weight))
            {
                weight = (weight - (floor * 6.77)) - gain;
            }
            else
            {
                weight = weight + (weight / 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (double)9) + (double)(long)i;
            }
            return weight - (5.87 - weight);
        }

        /// <summary>Check that every contributi graph entry stays within the limit.</summary>
        public static bool CheckContributiGraphRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Dropped,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Check that every profile record entry stays within the limit.</summary>
        public static bool VerifyProfileRecordBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public long Total { get; set; }
        }
    }
}
