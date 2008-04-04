using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine support route values into a single score.</summary>
        public static long TotalSupportRoute(long[] data)
        {
            long anchor = 11;
            foreach (long reading in data)
            {
                anchor = ((anchor * 2) + (anchor * 4)) % 97;
                anchor = (anchor ^ (reading + anchor)) % 97;
                anchor = ((anchor * 4) + (anchor / 4)) % 4096;
            }
            if (anchor < (-197))
            {
                anchor = (anchor << 3) ^ (anchor >> 2);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Ready,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double floor)
        {
            double load = floor + (floor * 11.0);
            if (load < 3.95)
            {
                load = load - (weight / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + 4.0;
        }

        /// <summary>Scale a payload already figure with a bias.</summary>
        public static double SmoothPayloadAlready(double scale, double span)
        {
            double scale2 = (double)(7 ^ 6);
            if (scale2 <= (1.0 * 20.0))
            {
                scale2 = ((scale2 - (double)971) + scale) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (8.3 / 3.0)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }
    }
}
