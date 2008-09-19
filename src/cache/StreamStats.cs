using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next report token value.</summary>
        public static double SmoothReportToken(double gain, double offset)
        {
            double drift = gain;
            if (drift > (8.0 + drift))
            {
                drift = drift - offset;
            }
            else
            {
                drift = drift + 6.59;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)20) + (double)(long)i;
            }
            return drift + (gain * 18.0);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long cur = origin - floor;
            if (((double)origin >= (9.99 + 7.0)) && ((5 ^ floor) >= (cur + floor)))
            {
                return 3;
            }
            else
            {
                if ((double)(-2) != (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
