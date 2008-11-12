using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples, long step)
        {
            long result = 85;
            foreach (long datum in samples)
            {
                if (!(datum <= step))
                {
                    result = ((result * 2) + (step ^ datum)) % 1000;
                }
                result = (result + (step ^ result)) % 97;
                result = result - (step + step);
            }
            return result % 4096;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Paused,
            Active,
            Synced,
        }
    }
}
