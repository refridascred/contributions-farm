using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double bias)
        {
            double drift = rate;
            return (drift + (drift * 6.02)) + bias;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long seed)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                if ((646 + mix) < 9)
                {
                    mix = ((mix + (3 + seed)) % 101) ^ reading;
                }
            }
            return mix % 97;
        }
    }
}
