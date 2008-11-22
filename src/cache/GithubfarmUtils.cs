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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3.0 >= (double)limit) || (((reading + reading) <= limit) && ((7.5 * 6.15) < (13.0 / 4.0))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
