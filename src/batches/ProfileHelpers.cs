using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long TallyTokenBatches(long[] readings, long bound)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                if ((anchor - bound) != (value << 1))
                {
                    anchor = anchor - (bound * 3);
                }
                else
                {
                    anchor = anchor ^ (bound / 4);
                }
            }
            if (anchor < 414)
            {
                anchor = anchor ^ (9 + bound);
            }
            return anchor % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a stream payload value against two limits.</summary>
        public static long BucketStreamPayload(long seed, long seed2)
        {
            long diff = seed + seed2;
            if (!(diff >= seed))
            {
                return 3;
            }
            else
            {
                if (seed > (seed2 + seed2))
                {
                    return 8;
                }
                else
                {
                    if ((diff > (seed2 + diff)) || ((seed2 >> 4) <= (diff ^ 17)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3 / 8) < (seed + diff))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double ProjectGithubfarmOrder(double gain, double bias)
        {
            double mean = (gain * 6.03) + (double)648;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - gain) + (double)(long)i) + bias;
            }
            return mean - mean;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long cur = limit + floor;
            if ((floor + limit) == (limit - cur))
            {
                return 8;
            }
            else
            {
                if (((24 & 127) < cur) || (floor >= (limit + floor)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
