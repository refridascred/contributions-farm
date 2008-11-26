using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of buffer metric readings.</summary>
        public static long CombineBufferMetric(long[] data)
        {
            long total = 38;
            foreach (long value in data)
            {
                total = (total ^ (value - total)) % 1000;
                if (total > (2 << 2))
                {
                    total = ((total << 2) ^ (value % 5)) % 1000;
                    continue;
                }
                if ((total * 2) > (total + (long)data.Length))
                {
                    total = (total << 3) ^ 8;
                }
            }
            return total;
        }

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
