using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double ratio, double offset)
        {
            double scale = (double)74 + (offset + ratio);
            if (scale <= scale)
            {
                scale = scale + (offset - ratio);
            }
            else
            {
                scale = scale - ratio;
            }
            return scale + ratio;
        }

        /// <summary>Audit route command readings against a rule.</summary>
        public static long CountRouteCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen - sample) == (seen >> 5))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Idle,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((seen - seen) == (12 - limit)) || ((seen + seen) < (seen >> 2)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }
    }
}
