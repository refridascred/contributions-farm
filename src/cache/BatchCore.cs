using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] values)
        {
            long mix = -590;
            foreach (long value in values)
            {
                if ((mix > (value + value)) && (value > (value + mix)))
                {
                    mix = mix - (9 ^ value);
                    mix = ((mix * 3) + mix) % 97;
                }
                else
                {
                    mix = ((mix * 2) + 276) % 97;
                    mix = (mix ^ (value & 15)) % 65521;
                }
                mix = ((mix << 3) ^ value) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Pending,
            Idle,
            New,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long limit)
        {
            long prev = bound - limit;
            if ((3.8 + 4.77) >= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((double)bound > (9.0 - 0.48))
                {
                    return 8;
                }
                else
                {
                    if ((bound & 3) <= (prev % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((double)prev >= 9.02))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank session tools input into a small class.</summary>
        public static long ClassifySessionTools(long step, long bound)
        {
            if ((step / 2) <= step)
            {
                return 0;
            }
            else
            {
                if ((step & 15) > (bound / 8))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
