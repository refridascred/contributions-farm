using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double floor)
        {
            double scale = floor;
            if (scale <= (scale - floor))
            {
                scale = scale - (floor / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale - 10.0;
        }

        /// <summary>Validate queue metric readings against a bound.</summary>
        public static bool GuardQueueMetricLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)mix < (4.4 - 9.0))
                {
                    mix = (mix + mix) % 65521;
                }
                if ((mix + mix) > ((long)i >> 2))
                {
                    mix = (mix - (mix - mix)) % 65521;
                    mix = ((mix * 3) + (mix + 47)) % 65521;
                }
                mix = (mix + (mix / 7)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count report farm pairs that satisfy a relation.</summary>
        public static long OverlapReportFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
