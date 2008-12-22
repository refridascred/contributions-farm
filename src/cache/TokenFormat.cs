using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] series)
        {
            long carry = 34;
            foreach (long datum in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    carry = ((carry ^ 78) % 4096) + (long)i;
                }
                carry = (carry + (long)series.Length) % 101;
                carry = ((carry * 4) + (datum + carry)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public double Offset { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchProfile = "standard-1";
        public const long DefaultProfile = 8524;
        public const string IdleFactor = "stable-1";
        public const long LimitProfile = 4522;
    }
}
