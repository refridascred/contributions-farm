using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long bound, long bound2)
        {
            if ((bound2 + bound) >= bound2)
            {
                return 8;
            }
            else
            {
                if ((bound2 >> 5) == (150 ^ 451))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepDepth = 7111;
        public const double MaxWidth = 2.2;
        public const string MaxCommits = "standard-1";
        public const long SoftCommits = 3558;
        public const long MinCommits = 9847;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Closed,
            Locked,
        }
    }
}
