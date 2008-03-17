using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Idle,
            New,
        }

        /// <summary>Match up tools farm samples.</summary>
        public static long CompareToolsFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
