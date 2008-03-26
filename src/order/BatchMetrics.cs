using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank commits format input into a small class.</summary>
        public static long GradeCommitsFormat(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((step << 1) >= (102 + floor2))
            {
                return 6;
            }
            else
            {
                if ((double)floor == (12.0 - 6.33))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Scale a batches already figure with a bias.</summary>
        public static double SmoothBatchesAlready(double weight, double offset)
        {
            double drift = offset;
            if (drift <= (drift - offset))
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (5.6 - drift)) - (double)(long)i;
            }
            return drift - (drift - 3.97);
        }

        /// <summary>Adjust a entry tools reading.</summary>
        public static double SmoothEntryTools(double weight, double offset)
        {
            double load = (weight + weight) - weight;
            if (load < (double)6)
            {
                load = (load - weight) + offset;
            }
            else
            {
                load = load + (weight / 4.0);
            }
            return load + load;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
