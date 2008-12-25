using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the stream support series from a seed.</summary>
        public static long IterateStreamSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Idle,
            Synced,
            Failed,
        }

        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster route counter forward.</summary>
        public static long DeriveClusterRoute(long origin)
        {
            long result = origin;
            for (int i = 0; i < 9; i++)
            {
                result = (result - (origin >> 5)) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
