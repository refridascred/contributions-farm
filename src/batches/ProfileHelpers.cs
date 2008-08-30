using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Active,
            Done,
            Ready,
            Pending,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long MaxLevel = 3887;
        public const double HardTimeout = 22.18;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Owner { get; set; }
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry + (carry & 1)) % 97) + datum;
            }
            if (carry < (-185))
            {
                carry = (carry + carry) % 4096;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 609;
            foreach (long entry in values)
            {
                result = (result ^ ((-239) ^ entry)) % 65521;
            }
            return result;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
