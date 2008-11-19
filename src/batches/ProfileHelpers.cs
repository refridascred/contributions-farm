using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine filter githubfarm values into a single score.</summary>
        public static long DigestFilterGithubfarm(long[] data)
        {
            long score = 0;
            foreach (long item in data)
            {
                if ((3 + score) < (score % 64))
                {
                    score = ((score + ((-976) + score)) % 255) ^ item;
                }
            }
            if (score < 93)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score % 4096;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double BlendChecks(double scale, double offset)
        {
            double weight = (double)(18 & 255);
            if (weight <= offset)
            {
                weight = weight + 1.1;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (weight - scale)) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long mix = 0;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (((mix ^ (mix & 7)) % 65521) - (long)i) ^ item;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = ((mix * 2) + ((-31) << 1)) - (long)i2;
                }
                mix = ((mix * 5) + ((-224) & 127)) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Draft,
            Idle,
            Done,
        }

        /// <summary>Audit metric order readings against a rule.</summary>
        public static long MeasureMetricOrderMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) > (192 + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((5 - cell) > (count / 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
