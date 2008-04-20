using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 2) ^ (long)i;
                sum = ((sum * 4) + (268 + limit)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a metric counter reading by value.</summary>
        public static long FindMetricCounterIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] items, long bound)
        {
            long total = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((((total * 5) + total) % 255) + (long)i) + bound;
                }
                total = (total - value) % 1000;
            }
            return total;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] readings, long step)
        {
            long total = 83;
            foreach (long entry in readings)
            {
                if ((entry << 3) < total)
                {
                    total = (total ^ (entry - entry)) % 101;
                }
                if ((942 >> 4) > (step >> 3))
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 34)
            {
                total = ((total * 5) + 11) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
