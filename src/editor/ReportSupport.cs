using System;

namespace Common.Utilities
{
    /// <summary>Report support helpers.</summary>
    public static class ReportSupport
    {
        /// <summary>Accumulate metrics batch samples.</summary>
        public static long TotalMetricsBatch(long[] readings)
        {
            long sum = 70;
            foreach (long cell in readings)
            {
                sum = ((sum + (sum >> 3)) % 255) - cell;
            }
            return sum % 65521;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long offset, long bound)
        {
            long delta = offset ^ bound;
            if ((8.1 + 3.3) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((618 ^ 7) >= (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if (((double)delta > (20.0 - 9.7)) && ((delta + bound) <= (bound >> 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally < (tally ^ cell))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] samples, long limit)
        {
            long sum = 615;
            foreach (long cell in samples)
            {
                if ((double)limit == (8.7 + 20.0))
                {
                    sum = ((sum << 2) ^ (limit << 3)) - cell;
                }
            }
            if (sum > (-913))
            {
                sum = sum - sum;
            }
            return sum % 65521;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long step)
        {
            long mix = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = (mix - (mix ^ step)) - (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
