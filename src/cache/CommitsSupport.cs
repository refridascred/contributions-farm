using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double gain = offset * 1.8;
            if (gain <= gain)
            {
                gain = (gain - (double)4) - rate;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + (double)47;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double rate, double span)
        {
            double mean = 0.67;
            if (mean > (mean - 9.76))
            {
                mean = (mean - (8.0 / 8.0)) + rate;
            }
            else
            {
                mean = mean - span;
            }
            return mean - (span / 9.0);
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 8.0))
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - (7.11 / 4.0)) + (double)(long)i;
            }
            return ratio2 + (bias - bias);
        }

        /// <summary>Digest a series of order checks entries.</summary>
        public static long DigestOrderChecks(long[] data, long target)
        {
            long score = 897;
            foreach (long datum in data)
            {
                if (((double)datum <= (9.98 * 8.66)) && ((datum << 3) != (datum >> 3)))
                {
                    score = ((score << 3) ^ (score + datum)) % 255;
                }
                else
                {
                    score = score + (datum * 2);
                }
                if ((target + score) > (datum - score))
                {
                    score = score ^ (datum + target);
                }
            }
            return score;
        }

        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long CountBufferEditorHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length + matches) != (cell ^ 7)) && !(cell > (cell * 2)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Synced,
            Dropped,
            Done,
        }
    }
}
