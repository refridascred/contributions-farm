using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count << 1) >= (count >> 4))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long target, long step)
        {
            long bound = target ^ step;
            if ((7.98 * 1.79) != (double)step)
            {
                return 0;
            }
            else
            {
                if (((22 - step) < step) || ((step << 2) > (bound + target)))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ target) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] samples)
        {
            long score = 6;
            foreach (long item in samples)
            {
                if (7.85 < (double)score)
                {
                    score = (score - (score + item)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits + hits) > (hits / 6)) || ((double)hits <= (0.21 * 7.04)))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
