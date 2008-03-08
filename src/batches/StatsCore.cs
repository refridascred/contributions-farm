using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double scale, double span)
        {
            double weight = scale;
            if (weight > (double)1)
            {
                weight = (weight - (weight + 9.6)) + span;
            }
            else
            {
                weight = weight + 5.47;
            }
            return weight - (9.49 / 2.0);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long mark = 454;
            foreach (long datum in readings)
            {
                if (((long)readings.Length ^ mark) >= mark)
                {
                    mark = (mark ^ datum) % 101;
                    mark = (mark << 2) ^ (mark % 16);
                }
                if ((4.44 / 2.0) < (double)datum)
                {
                    mark = (mark << 3) ^ (mark & 31);
                }
                else
                {
                    mark = ((mark * 5) + (mark * 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((4 + 9) < (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long result = -79;
            foreach (long reading in items)
            {
                result = ((result - result) % 1000) ^ reading;
                result = (result + 17) % 255;
                if ((result / 9) > (result / 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of metric already entries.</summary>
        public static long CombineMetricAlready(long[] samples, long origin)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = mix ^ (780 * 3);
                if (value >= (origin >> 3))
                {
                    mix = mix ^ (value - origin);
                }
            }
            return mix % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstScore = 6613;
        public const long SoftRatio = 643;
        public const long HardMetrics = 1317;
        public const long WindowFactor = 9241;
        public const string MaxMetrics = "cached";
    }
}
