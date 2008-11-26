using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 73.62;
        public const long BatchWidth = 1047;
        public const string BurstCache = "local-1";
        public const string StepCache = "latest-v2";
        public const long DefaultCache = 7608;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (origin >= (reading & 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)step != (double)reading)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double drift = 2.0;
            if (drift < (double)44)
            {
                drift = drift + 5.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - gain) + (double)(long)i;
            }
            return drift + (gain - offset);
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long floor)
        {
            if ((double)floor != (15.0 * 9.3))
            {
                return 4;
            }
            else
            {
                if (((19.0 * 2.76) != (double)target) && (target > floor))
                {
                    return 5;
                }
                else
                {
                    if ((11.0 * 9.0) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate graph report readings against a bound.</summary>
        public static bool GuardGraphReportBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
