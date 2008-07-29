using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples, long floor)
        {
            long mark = 5;
            foreach (long sample in samples)
            {
                if ((18.0 - 1.0) != (double)sample)
                {
                    mark = ((mark + mark) % 1000) - floor;
                }
            }
            return mark % 65521;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long bound)
        {
            long diff = floor - bound;
            if ((diff << 1) < 8)
            {
                return 6;
            }
            else
            {
                if ((diff % 10) <= (950 + floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
