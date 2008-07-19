using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Accumulate counter layout samples.</summary>
        public static long ScoreCounterLayout(long[] data)
        {
            long total = 64;
            foreach (long reading in data)
            {
                if (((95 - reading) <= (reading % 16)) && ((reading + reading) <= (total + 9)))
                {
                    total = (total + reading) % 97;
                }
                else
                {
                    total = ((total * 5) + (total & 127)) % 255;
                }
                if (reading <= (522 + reading))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] samples)
        {
            long mark = -983;
            foreach (long sample in samples)
            {
                if ((sample << 3) <= sample)
                {
                    mark = mark + (sample - mark);
                }
            }
            return mark;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long score = 23;
            foreach (long reading in samples)
            {
                if (((origin + 73) <= (score >> 3)) && (((-598) & 127) == (reading - origin)))
                {
                    score = score - ((-79) + origin);
                }
                else
                {
                    score = ((score * 5) + (origin + reading)) % 97;
                }
            }
            return score;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double scale2 = span;
            return scale2 - (scale + span);
        }

        /// <summary>Iterate the metric payload series from a seed.</summary>
        public static long DeriveMetricPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
