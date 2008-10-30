using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 15; i++)
            {
                if ((4.0 + 5.22) != (double)floor)
                {
                    mark = ((mark * 4) + (mark >> 1)) % 101;
                }
                else
                {
                    mark = mark ^ (floor >> 3);
                }
                if (!((double)mark != (double)(long)i))
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Accumulate buffer window samples.</summary>
        public static long FoldBufferWindow(long[] readings, long seed)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = (mix - (seed - mix)) - sample;
            }
            return mix;
        }
    }
}
