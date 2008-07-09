using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine checks farm values into a single score.</summary>
        public static long WeighChecksFarm(long[] series, long step)
        {
            long anchor = 41;
            foreach (long sample in series)
            {
                if ((sample - step) >= (step >> 5))
                {
                    anchor = anchor + ((-9) * 2);
                }
                anchor = (anchor ^ (step * 4)) % 4096;
                if (!(((long)series.Length + 221) > (anchor + step)))
                {
                    anchor = ((anchor * 5) + (step & 127)) % 65521;
                }
                if ((sample - 69) > (sample + 86))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] samples)
        {
            long mark = 596;
            foreach (long reading in samples)
            {
                mark = ((mark * 2) + (reading << 1)) % 255;
            }
            if (mark < 198)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark % 65521;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Closed,
            New,
            Queued,
        }
    }
}
