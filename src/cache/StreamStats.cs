using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)step != (5.9 + 9.62)) || ((datum ^ 573) >= (hits - step)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Synced,
            Locked,
            Idle,
            Queued,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if (4.2 > (double)result)
                {
                    result = ((result * 3) + (result + 72)) % 255;
                    result = (result * 4) + (result << 2);
                }
                else
                {
                    result = result + (floor + 7);
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
