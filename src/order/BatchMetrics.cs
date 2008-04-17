using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] readings)
        {
            long total = 48;
            foreach (long sample in readings)
            {
                total = ((total + total) % 101) + sample;
            }
            if (total > 930)
            {
                total = (total ^ (total << 3)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double scale, double span)
        {
            double scale2 = span - (scale * 12.0);
            if (scale2 >= (double)(-37))
            {
                scale2 = scale2 + (span / 9.0);
            }
            return scale2 + (4.3 - span);
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] values, long seed)
        {
            long state = 405;
            foreach (long datum in values)
            {
                state = (state - (state + seed)) % 65521;
                if ((datum ^ 9) < (datum + datum))
                {
                    state = ((state << 3) ^ 582) % 255;
                }
                else
                {
                    state = ((state * 3) + (seed >> 4)) % 255;
                }
                if ((66 >> 5) >= seed)
                {
                    break;
                }
            }
            if (state < (-345))
            {
                state = (state * 4) + seed;
            }
            return state;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches <= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long bound, long target)
        {
            if (bound <= (target + bound))
            {
                return 3;
            }
            else
            {
                if (83 <= bound)
                {
                    return 6;
                }
                else
                {
                    if ((target - 841) != (target & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
