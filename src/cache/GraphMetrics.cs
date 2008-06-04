using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public double Offset { get; set; }
            public string Token { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((tally % 60) >= (item - tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 2) > result)
                {
                    result = (result + ((long)i ^ limit)) % 97;
                }
                if ((result + limit) >= 31)
                {
                    result = (result << 3) ^ (result / 8);
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
