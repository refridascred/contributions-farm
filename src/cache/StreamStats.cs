using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate schema cache readings against a bound.</summary>
        public static bool VerifySchemaCacheRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] samples, long origin)
        {
            long result = 744;
            foreach (long datum in samples)
            {
                if (5 >= result)
                {
                    result = (((result * 2) + (origin * 5)) % 97) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Idle,
            Paused,
            Closed,
            Failed,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] series, long target)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if ((167 * 4) != (mix * 3))
                {
                    mix = ((mix << 3) ^ (mix % 3)) - datum;
                }
                else
                {
                    mix = (mix << 2) ^ (target ^ (long)series.Length);
                }
            }
            return mix % 4096;
        }
    }
}
