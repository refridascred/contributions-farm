using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data, long floor)
        {
            long mix = -5;
            foreach (long cell in data)
            {
                mix = (mix ^ mix) ^ cell;
                mix = (mix + floor) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double bias, double span)
        {
            double drift = (span / 3.0) * 4.07;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (bias - 4.2);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)6 > (double)count) || ((double)count <= (4.0 - 8.3)))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
