using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of buffer githubfarm readings.</summary>
        public static long MatchBufferGithubfarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + (long)i) == (long)i)
                {
                    total = ((total * 5) + ((long)i % 100)) % 1000;
                    continue;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((seed - (long)values.Length) < entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = (score + (floor / 2)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
