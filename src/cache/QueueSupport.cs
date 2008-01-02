using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] series, long offset)
        {
            long result = 464;
            foreach (long reading in series)
            {
                if ((reading * 5) > ((long)series.Length ^ offset))
                {
                    result = result - ((-4) / 8);
                }
                else
                {
                    result = (result << 3) ^ (result - offset);
                }
            }
            return result % 97;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseInterval = "staging-edge";
        public const double IdleCount = 19.51;
        public const string BurstTimeout = "primary-1";
    }
}
