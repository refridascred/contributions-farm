using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
