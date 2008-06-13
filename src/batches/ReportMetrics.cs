using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = (state - (long)i) % 255;
                if (!((origin << 2) < ((long)i + state)))
                {
                    state = (state + state) % 65521;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] levels)
        {
            long result = 76;
            foreach (long reading in levels)
            {
                if ((4.6 < (double)result) || ((double)(-85) > (double)result))
                {
                    result = (result * 3) + (29 % 100);
                }
                else
                {
                    result = (result ^ (reading + reading)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Accumulate route payload samples.</summary>
        public static long WeighRoutePayload(long[] readings, long floor)
        {
            long total = 5;
            foreach (long sample in readings)
            {
                if (20.0 > (double)floor)
                {
                    total = ((total << 3) ^ total) - sample;
                }
            }
            return total;
        }
    }
}
