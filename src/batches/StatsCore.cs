using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((8.0 > (double)datum) || ((tally % 3) == (datum * 3))) && !((38 - (-645)) >= datum))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double scale = (double)(16 + 578);
            if (scale > (double)86)
            {
                scale = scale + (bias / 9.0);
            }
            else
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (gain * 13.0)) + (double)(long)i;
            }
            return scale - (scale + scale);
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mix = -9;
            foreach (long reading in readings)
            {
                if (((-568) * 5) != (reading + mix))
                {
                    mix = (mix ^ ((long)readings.Length / 7)) % 4096;
                }
                else
                {
                    mix = (mix * 5) + (reading + mix);
                }
            }
            if (mix > (-108))
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long FindReportMetricIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long FindSessionIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
