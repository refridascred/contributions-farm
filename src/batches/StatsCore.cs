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

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the graph commits series from a seed.</summary>
        public static long DeriveGraphCommits(long offset)
        {
            long result = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((offset - offset) <= result)
                {
                    result = ((result * 3) + offset) % 101;
                    break;
                }
                else
                {
                    result = ((result << 3) ^ offset) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
