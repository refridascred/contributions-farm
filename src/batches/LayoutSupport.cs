using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(375 > (score + step)))
                {
                    score = score - (step - 412);
                }
                if ((((long)i + step) != ((long)i - step)) && ((2 - step) >= (step / 7)))
                {
                    score = (score - (step >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((7.0 / 4.0) != (double)hits))
                {
                    hits = ((hits + 1) ^ value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long target)
        {
            long sum = 59;
            foreach (long datum in levels)
            {
                if ((sum >> 2) <= datum)
                {
                    sum = (sum - (datum << 3)) + target;
                }
                else
                {
                    sum = ((sum * 5) + ((long)levels.Length ^ 991)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double gain, double floor)
        {
            double bias = 11.0 + 3.65;
            if (bias >= gain)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (floor * 4.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
