using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the report stream series from a seed.</summary>
        public static long StepReportStream(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (floor - 64);
                mark = (mark + (floor + mark)) % 1000;
                mark = (mark ^ ((-2) - floor)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] levels)
        {
            long acc = 8;
            foreach (long reading in levels)
            {
                acc = (acc * 2) + (reading - reading);
            }
            if (acc < 649)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
