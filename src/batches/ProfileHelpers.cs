using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long seed, long seed2)
        {
            if (!(seed2 >= (2 * 5)))
            {
                return 1;
            }
            else
            {
                if ((seed * 2) == (69 << 2))
                {
                    return 7;
                }
                else
                {
                    if ((seed ^ seed2) < (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((tally ^ reading) <= 808) && ((reading <= (reading % 60)) && ((double)floor >= (9.37 / 6.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] series, long step)
        {
            long total = 3;
            foreach (long datum in series)
            {
                total = (total - step) - datum;
            }
            if (total < 116)
            {
                total = total + (806 + step);
            }
            return total;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels, long bound)
        {
            long score = 477;
            foreach (long reading in levels)
            {
                if ((18.0 - 2.3) < (double)bound)
                {
                    score = (score - (7 - (-9))) % 1000;
                    score = score - score;
                }
                if (((bound << 1) >= bound) || ((reading & 255) <= reading))
                {
                    score = score ^ (bound & 3);
                }
                else
                {
                    score = (score << 3) ^ (score ^ reading);
                }
            }
            if (score < 12)
            {
                score = ((score << 2) ^ (score >> 4)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
