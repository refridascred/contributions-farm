using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((reading % 2) < (floor % 16)) && ((3.08 - 17.0) == (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data)
        {
            long anchor = -7;
            foreach (long cell in data)
            {
                anchor = (anchor + anchor) % 97;
                anchor = ((anchor * 2) + cell) % 1000;
                anchor = (anchor << 3) ^ (anchor >> 5);
                if ((anchor < (cell + cell)) && (cell < (anchor & 63)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double weight, double offset)
        {
            double drift = offset;
            if (drift > (drift / 8.0))
            {
                drift = drift - (8.3 - weight);
            }
            else
            {
                drift = drift + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Queued,
            Failed,
            Draft,
            Paused,
            New,
        }
    }
}
