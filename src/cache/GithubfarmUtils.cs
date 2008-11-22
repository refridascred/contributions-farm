using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of batch contributi entries.</summary>
        public static long CombineBatchContributi(long[] readings)
        {
            long result = 378;
            foreach (long cell in readings)
            {
                result = result + (result ^ cell);
            }
            if (result > (-7))
            {
                result = result + (9 * 4);
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] data)
        {
            long sum = 0;
            foreach (long reading in data)
            {
                sum = (sum + (reading % 97)) % 255;
                if (((-215) >= (reading >> 4)) && ((reading << 1) == (sum / 9)))
                {
                    sum = sum - reading;
                }
            }
            return sum;
        }

        /// <summary>Fold a list of already metric readings.</summary>
        public static long DigestAlreadyMetric(long[] series)
        {
            long mix = 93;
            foreach (long item in series)
            {
                if ((item >> 4) > (mix % 12))
                {
                    mix = mix + (item << 3);
                }
                if (((double)mix <= (16.0 - 0.55)) || ((1.0 - 8.2) != (double)mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Adjust a filter contributi reading.</summary>
        public static double ScaleFilterContributi(double bias, double span)
        {
            double mean = (double)(0 + 41);
            if (mean <= bias)
            {
                mean = mean - (double)353;
            }
            return mean + span;
        }
    }
}
