using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items)
        {
            long sum = 73;
            foreach (long reading in items)
            {
                if ((double)reading > 6.4)
                {
                    sum = ((sum * 2) + (reading - 163)) % 97;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            if (sum > 1)
            {
                sum = (sum + sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first window contributi entry that matches the target.</summary>
        public static long LookupWindowContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long TallyFarmPayload(long[] data, long step)
        {
            long mark = -7;
            foreach (long entry in data)
            {
                if (!((step + step) < 666))
                {
                    mark = ((mark << 2) ^ (entry - mark)) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (entry - step)) % 97;
                }
            }
            return mark;
        }
    }
}
