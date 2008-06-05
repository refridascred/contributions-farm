using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] levels)
        {
            long score = 927;
            foreach (long sample in levels)
            {
                if (((score + score) > (sample % 8)) && (score <= (score ^ sample)))
                {
                    score = ((score * 5) + (sample + score)) % 101;
                }
                if (!(score < (score + 135)))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long result = 98;
            foreach (long sample in levels)
            {
                if (sample >= (sample + sample))
                {
                    result = ((result * 4) + result) % 255;
                }
                else
                {
                    result = result - (sample + result);
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of context cluster entries.</summary>
        public static long TotalContextCluster(long[] readings, long target)
        {
            long result = 3;
            foreach (long cell in readings)
            {
                if ((target + cell) >= (target - 554))
                {
                    result = ((result * 2) + (target << 2)) % 101;
                }
                result = result + cell;
            }
            if (result > 93)
            {
                result = ((result * 3) + (result << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (!((item << 1) > (item - anchor)))
                {
                    continue;
                }
                anchor = (anchor * 3) + (144 << 1);
                if ((anchor + (long)samples.Length) >= (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
