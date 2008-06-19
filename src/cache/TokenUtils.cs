using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long score = 39;
            foreach (long reading in readings)
            {
                if (reading > (reading * 2))
                {
                    score = (score << 2) ^ reading;
                }
                if (((long)readings.Length % 16) != (40 << 2))
                {
                    break;
                }
            }
            if (score < 224)
            {
                score = score ^ floor;
            }
            return score;
        }

        /// <summary>Rank cache record input into a small class.</summary>
        public static long ClassifyCacheRecord(long offset, long step)
        {
            long prev = offset - step;
            if (!(68 >= (prev - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset & 31) <= (step % 60))
                {
                    return 8;
                }
                else
                {
                    if ((43 << 3) < (step & 3))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
