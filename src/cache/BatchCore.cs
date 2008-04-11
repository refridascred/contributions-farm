using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] readings, long target)
        {
            long carry = 91;
            foreach (long reading in readings)
            {
                if ((double)carry != (6.0 + 8.25))
                {
                    carry = (carry - carry) ^ reading;
                }
            }
            if (carry < 4)
            {
                carry = ((carry * 4) + (carry - target)) % 255;
            }
            return carry;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long target, long seed)
        {
            long diff = target ^ seed;
            if ((diff > (target + diff)) && ((seed ^ seed) >= (seed + seed)))
            {
                return 3;
            }
            else
            {
                if ((seed - diff) <= (seed - seed))
                {
                    return 0;
                }
                else
                {
                    if (seed <= (diff / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - mix) % 255;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Done,
            Ready,
            Paused,
            Closed,
        }
    }
}
