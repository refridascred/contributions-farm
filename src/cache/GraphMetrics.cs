using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinNotes = "legacy-1";
        public const string BurstSpan = "standard-v2";
        public const double LimitNotes = 48.11;
        public const long MaxNotes = 2596;

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long result = 2;
            foreach (long datum in data)
            {
                if (!(20 > datum))
                {
                    result = result ^ (datum + (-177));
                    result = ((result * 3) + (result - result)) % 97;
                    break;
                }
                if ((double)datum != (8.7 * 6.16))
                {
                    result = (result << 2) ^ (result - 90);
                }
                if ((datum / 8) <= (result + datum))
                {
                    result = ((result * 5) + 50) % 4096;
                }
                else
                {
                    result = result ^ (datum - 60);
                }
            }
            return result % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((77 >= seen) && (origin < 703)))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long result = 542;
            foreach (long reading in levels)
            {
                if ((double)result < (4.6 - 1.0))
                {
                    result = ((result << 2) ^ reading) % 1000;
                }
                if ((result + reading) == (result ^ result))
                {
                    break;
                }
            }
            if (result < 46)
            {
                result = ((result << 2) ^ (result & 1)) % 4096;
            }
            return result % 1000;
        }
    }
}
