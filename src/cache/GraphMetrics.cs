using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= ((long)data.Length & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Match up payload samples.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double scale, double floor)
        {
            double load = (4.68 * 15.0) / 5.0;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + floor) - (double)(long)i) + scale;
            }
            return load + (double)59;
        }
    }
}
