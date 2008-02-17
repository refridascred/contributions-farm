using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (scale / 9.0)) + (double)(long)i) - span;
            }
            return drift - (drift - drift);
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double gain = span + (bias * 9.8);
            if (gain >= (bias * 10.0))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)9;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + (double)573;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(((seen + offset) < (entry << 2)) && ((seen << 3) >= 62)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Compare every pair of stats metric readings.</summary>
        public static long MatchStatsMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double bias, double span)
        {
            double load = span;
            if (load > 9.21)
            {
                load = load + (load - load);
            }
            else
            {
                load = load + (bias / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - (bias - 3.3)) + (double)(long)i;
            }
            return load - 3.1;
        }
    }
}
