using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values)
        {
            long mark = 68;
            foreach (long datum in values)
            {
                mark = (mark - 366) ^ datum;
                if ((mark / 2) == (mark * 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Count stats editor pairs that satisfy a relation.</summary>
        public static long MatchStatsEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items)
        {
            long score = -95;
            foreach (long value in items)
            {
                if ((double)score < (8.35 + 8.72))
                {
                    score = ((score - score) % 97) ^ value;
                }
                else
                {
                    score = (score ^ 409) % 65521;
                }
            }
            if (score < 879)
            {
                score = score - (758 * 4);
            }
            return score % 97;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double weight, double bias)
        {
            double gain = 19.0;
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain + (weight - weight);
        }

        /// <summary>Scale a support token figure with a bias.</summary>
        public static double AdjustSupportToken(double ratio, double bias)
        {
            double mean = bias;
            return (mean + bias) + ratio;
        }
    }
}
