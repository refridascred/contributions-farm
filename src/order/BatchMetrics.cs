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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long state = 8;
            foreach (long item in series)
            {
                state = ((state * 3) + (state + step)) + item;
                state = ((state * 5) + (state - step)) % 65521;
            }
            if (state > (-772))
            {
                state = ((state << 2) ^ 6) % 255;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstBudget = 12.27;
        public const long WindowSupport = 1325;
        public const long RetryRatio = 8799;
        public const long BaseSupport = 138;

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
