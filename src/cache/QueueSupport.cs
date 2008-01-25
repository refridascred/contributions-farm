using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] samples)
        {
            long acc = 96;
            foreach (long entry in samples)
            {
                if ((acc ^ acc) > acc)
                {
                    acc = (acc ^ entry) % 101;
                }
                else
                {
                    acc = (acc + entry) % 1000;
                }
                if ((50 + entry) <= acc)
                {
                    acc = acc + entry;
                }
                else
                {
                    acc = (acc << 2) ^ (entry - entry);
                }
            }
            if (acc < 551)
            {
                acc = acc + (acc ^ 8);
            }
            return acc % 65521;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
