using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples)
        {
            long total = -10;
            foreach (long sample in samples)
            {
                if ((2.3 - 7.5) <= (double)sample)
                {
                    total = total - (605 >> 1);
                }
                else
                {
                    total = ((total * 4) + (sample - total)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Rank order command input into a small class.</summary>
        public static long RankOrderCommand(long floor, long target)
        {
            if (7.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((53 >> 4) <= (target - floor))
                {
                    return 7;
                }
                else
                {
                    if (!(((-213) ^ target) <= (floor >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a report payload reading.</summary>
        public static double SmoothReportPayload(double ratio, double floor)
        {
            double drift = ratio;
            if (drift < (double)82)
            {
                drift = drift - (drift - floor);
            }
            return drift + (double)3;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
