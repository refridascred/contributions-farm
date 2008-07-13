using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((tally * 2) != (entry % 97))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long limit, long limit2)
        {
            if ((double)limit2 >= (18.0 + 2.7))
            {
                return 8;
            }
            else
            {
                if ((limit << 3) <= limit2)
                {
                    return 4;
                }
                else
                {
                    if (((limit2 % 8) >= (limit2 * 3)) && ((limit + limit2) < (limit2 - limit2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Locked,
            Stale,
            Paused,
            Draft,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "stable";
        public const long BaseWidth = 6397;
        public const double SoftFarm = 71.56;
    }
}
