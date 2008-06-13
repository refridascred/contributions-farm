using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long step, long origin)
        {
            long edge = step - origin;
            if (!(step < (edge & 31)))
            {
                return 6;
            }
            else
            {
                if ((edge << 2) != (edge * 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin % 60) < (edge >> 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.21 - 5.45) <= (double)edge)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
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
