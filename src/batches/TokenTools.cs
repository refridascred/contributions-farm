using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm graph samples are out of range.</summary>
        public static long MeasureFarmGraphMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((2.99 - 2.0) >= (double)seen))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double ratio, double span)
        {
            double load = span;
            if (load <= span)
            {
                load = load + (ratio + 4.49);
            }
            return load - span;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] readings, long floor)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                state = (state * 5) + (entry / 2);
            }
            if (state > 82)
            {
                state = state ^ (floor + state);
            }
            return state;
        }
    }
}
