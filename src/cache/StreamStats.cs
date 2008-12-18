using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine report checks values into a single score.</summary>
        public static long TotalReportChecks(long[] samples, long limit)
        {
            long mark = 934;
            foreach (long reading in samples)
            {
                if (((reading + 77) <= mark) && ((1.5 / 6.0) < (double)limit))
                {
                    mark = (mark - reading) % 1000;
                    break;
                }
                if (limit >= (mark + reading))
                {
                    mark = mark + (mark + mark);
                    mark = mark + (-931);
                }
                else
                {
                    mark = (mark * 5) + (mark + 655);
                    mark = (mark + (mark + mark)) % 255;
                }
                mark = (mark - (limit << 1)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Validate counter window readings against a bound.</summary>
        public static bool CheckCounterWindowRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a editor commits value against two limits.</summary>
        public static long ClassifyEditorCommits(long limit, long floor)
        {
            long edge = limit ^ floor;
            if (limit >= (edge - 4))
            {
                return 7;
            }
            else
            {
                if (!(9.64 >= (double)floor))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                if (8 <= (state >> 5))
                {
                    state = ((state << 3) ^ (origin / 5)) % 255;
                    state = (state * 5) + ((long)i + 787);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
