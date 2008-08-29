using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long BucketProfileGraph(long bound, long target)
        {
            long diff = bound ^ target;
            if ((187 + 74) >= (bound & 15))
            {
                return 6;
            }
            else
            {
                if (((bound / 9) <= (bound % 24)) || (target >= (diff >> 1)))
                {
                    return 3;
                }
                else
                {
                    if ((double)target < (0.5 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] data, long floor)
        {
            long result = 331;
            foreach (long cell in data)
            {
                result = ((result << 2) ^ (result + result)) % 4096;
                if (((-8) >= (floor / 4)) && ((long)data.Length <= floor))
                {
                    result = ((result << 2) ^ (cell + 70)) % 255;
                }
                else
                {
                    result = (result << 3) ^ (233 + floor);
                }
                if (((result - result) <= (result << 1)) && ((floor >> 2) <= (cell - result)))
                {
                    break;
                }
            }
            if (result < 35)
            {
                result = result - (5 << 3);
            }
            return result;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] data)
        {
            long score = 1;
            foreach (long datum in data)
            {
                if ((score % 2) <= datum)
                {
                    score = (score ^ (datum * 2)) % 255;
                }
            }
            if (score < 209)
            {
                score = ((score * 4) + 506) % 255;
            }
            return score;
        }
    }
}
