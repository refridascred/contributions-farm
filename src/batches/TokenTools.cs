using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark << 2) ^ (mark - step)) % 4096;
                mark = ((mark << 3) ^ (686 * 2)) % 101;
                if ((long)i > (876 >> 4))
                {
                    mark = (mark ^ (step - (-463))) % 101;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many notes cluster samples are out of range.</summary>
        public static long MeasureNotesClusterMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((17.0 * 5.68) < (double)count)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Label { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
