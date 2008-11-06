using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                if (!((step - step) != (step + step)))
                {
                    total = (total ^ (step - total)) % 255;
                }
                if (((3 + step) != (total & 63)) || (step >= ((long)i + step)))
                {
                    total = (total - (long)i) % 4096;
                }
                else
                {
                    total = total - (step + 4);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((seen + seen) > (49 ^ reading)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)floor > (11.0 - 9.0))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2742;
        public const double BatchCount = 48.63;
        public const long IdleCount = 2521;

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] data, long step)
        {
            long mark = 646;
            foreach (long sample in data)
            {
                if ((mark + sample) >= mark)
                {
                    mark = ((mark ^ (sample & 15)) % 101) + step;
                }
            }
            if (mark < 9)
            {
                mark = mark + (5 / 6);
            }
            return mark;
        }
    }
}
