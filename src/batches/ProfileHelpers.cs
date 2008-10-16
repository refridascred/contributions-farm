using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TallyContext(long[] readings, long limit)
        {
            long mix = 9;
            foreach (long entry in readings)
            {
                mix = (mix ^ (538 + mix)) + entry;
            }
            if (mix > (-576))
            {
                mix = (mix * 2) + limit;
            }
            return mix % 4096;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double bias, double floor)
        {
            double weight = (floor / 4.0) - (double)9;
            if (weight > (double)7)
            {
                weight = weight + (floor / 4.0);
            }
            else
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (bias / 8.0)) + (double)(long)i;
            }
            return weight + (9.0 / 9.0);
        }
    }
}
