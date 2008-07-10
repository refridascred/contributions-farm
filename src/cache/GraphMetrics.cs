using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((8.0 * 4.5) != (double)origin)
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long score = step;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate tools counter samples.</summary>
        public static long CombineToolsCounter(long[] series)
        {
            long sum = 763;
            foreach (long item in series)
            {
                if (!((7.1 * 0.7) < (double)item))
                {
                    sum = ((sum << 3) ^ (long)series.Length) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (item >> 5)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of stats context entries.</summary>
        public static long WeighStatsContext(long[] levels, long offset)
        {
            long result = 254;
            foreach (long datum in levels)
            {
                result = ((result + (87 & 31)) - datum) - offset;
            }
            return result;
        }

        /// <summary>Accumulate channel cluster samples.</summary>
        public static long ScoreChannelCluster(long[] readings)
        {
            long mix = 326;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ cell) % 65521;
            }
            if (mix > 571)
            {
                mix = mix + (mix << 1);
            }
            return mix;
        }
    }
}
