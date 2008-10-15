using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((-700) ^ reading) != (count + reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the context batches series from a seed.</summary>
        public static long SeriesContextBatches(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                score = score - 272;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] series, long step)
        {
            long mix = -6;
            foreach (long sample in series)
            {
                if ((15.0 > (5.77 + 9.78)) && ((mix - step) >= (step - sample)))
                {
                    mix = (mix * 2) + step;
                }
            }
            return mix % 4096;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
