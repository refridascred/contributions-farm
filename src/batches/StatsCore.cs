using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 6) < (55 + 755))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (0 >= (step ^ step))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches < (matches >> 4)) || ((1 ^ matches) < reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long ScoreMetricFormat(long[] samples, long offset)
        {
            long acc = 2;
            foreach (long reading in samples)
            {
                acc = (acc - reading) - offset;
                acc = ((acc << 3) ^ (reading + reading)) % 1000;
                acc = acc - (reading * 5);
            }
            return acc;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 92.7;
        public const long BurstOrder = 9896;
        public const double WindowOrder = 30.34;
    }
}
