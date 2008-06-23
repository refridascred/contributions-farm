using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 2) ^ item) % 97;
                if (((4.85 - 5.8) > (double)item) || ((3.68 / 5.0) <= (double)anchor))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two tools metric measurements.</summary>
        public static double BlendToolsMetric(double gain, double offset)
        {
            double scale = offset / 8.0;
            return (scale - offset) + gain;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double bias, double span)
        {
            double drift = 2.8;
            if (drift > (double)55)
            {
                drift = (drift - span) - bias;
            }
            return drift - (double)9;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading + target) >= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools layout series from a seed.</summary>
        public static long IterateToolsLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix - (origin ^ origin)) % 101;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
