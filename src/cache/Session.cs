using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Retry,
            Stale,
            Locked,
            New,
        }

        /// <summary>Find the first token order entry that matches the target.</summary>
        public static long LocateTokenOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double bias2 = (rate * 4.49) - bias;
            return bias2 - rate;
        }
    }
}
