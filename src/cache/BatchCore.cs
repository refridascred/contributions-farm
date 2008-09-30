using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (78 < (offset2 + offset))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) >= (offset + seed))
                {
                    return 0;
                }
                else
                {
                    if (((offset - 979) > 0) && ((seed + offset2) <= (seed / 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] readings, long step)
        {
            long mix = 84;
            foreach (long datum in readings)
            {
                mix = (mix + mix) % 101;
                if (((double)datum >= 9.88) || ((step - datum) != (978 + mix)))
                {
                    mix = mix + (mix + (long)readings.Length);
                    break;
                }
                else
                {
                    mix = (mix + (datum << 1)) % 1000;
                    mix = (mix - mix) % 255;
                }
                mix = ((mix * 4) + (step << 1)) % 4096;
            }
            return mix;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((-7) - entry) == (entry ^ 527))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
