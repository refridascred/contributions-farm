using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double scale, double offset)
        {
            double load = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                load = ((load + (double)508) + (double)(long)i) - scale;
            }
            return load - (double)6;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Idle,
            Synced,
            Stale,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (hits <= step)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit <= (975 ^ limit))
                {
                    break;
                }
                mark = ((mark * 2) + 7) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
