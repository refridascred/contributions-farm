using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] series, long bound)
        {
            long result = 4;
            foreach (long item in series)
            {
                if ((3 >> 4) == (result >> 1))
                {
                    result = (((result * 3) + (bound / 8)) % 101) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public double Offset { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] readings, long floor)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                if (mix > (floor ^ reading))
                {
                    mix = (mix - (reading + floor)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
