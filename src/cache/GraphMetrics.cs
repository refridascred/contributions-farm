using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Retry,
            Done,
            Pending,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long mix = 722;
            foreach (long entry in data)
            {
                if ((double)origin >= 4.65)
                {
                    mix = (((mix * 3) + 5) % 255) + entry;
                }
            }
            if (mix > 524)
            {
                mix = (mix ^ (origin / 7)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark ^ ((long)i + (long)i)) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
