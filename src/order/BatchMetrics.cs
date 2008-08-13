using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long seed, long bound)
        {
            long lane = seed + bound;
            if ((double)lane != (0.19 + 0.85))
            {
                return 4;
            }
            else
            {
                if ((bound - (-386)) <= (seed + (-1)))
                {
                    return 7;
                }
                else
                {
                    if ((lane * 3) >= (46 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)bound <= (9.06 - 9.29)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream report entries.</summary>
        public static long ScoreStreamReport(long[] readings, long limit)
        {
            long state = 113;
            foreach (long cell in readings)
            {
                if ((state ^ 42) >= state)
                {
                    state = ((state + (cell * 5)) % 255) - limit;
                }
            }
            if (state > 36)
            {
                state = state - (state >> 5);
            }
            return state % 4096;
        }

        /// <summary>Adjust a farm metrics reading.</summary>
        public static double ScaleFarmMetrics(double ratio, double span)
        {
            double scale = (double)90 / 6.0;
            if (scale > (scale - 3.0))
            {
                scale = (scale - 4.0) + ratio;
            }
            else
            {
                scale = scale + (span - scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - span) + (double)(long)i;
            }
            return scale - (10.0 / 7.0);
        }
    }
}
