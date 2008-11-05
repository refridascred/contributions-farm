using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepSpan = 79.17;
        public const long DefaultAlready = 9153;
        public const string BurstScore = "stable-v2";
        public const double HardInterval = 46.7;

        /// <summary>Derive the next queue window value from a seed.</summary>
        public static long StepQueueWindow(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (step / 8)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
