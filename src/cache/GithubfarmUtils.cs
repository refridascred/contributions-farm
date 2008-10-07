using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] values, long limit)
        {
            long mark = 60;
            foreach (long reading in values)
            {
                mark = ((mark - (reading & 15)) % 97) - limit;
            }
            return mark;
        }

        /// <summary>Check that every format layout entry stays within the limit.</summary>
        public static bool CheckFormatLayoutRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Iterate the profile channel series from a seed.</summary>
        public static long RollProfileChannel(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = (mix ^ ((long)i - bound)) % 97;
                if (((bound & 31) < (mix - bound)) && ((double)mix != (0.1 * 2.86)))
                {
                    mix = mix ^ (306 + (long)i);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
