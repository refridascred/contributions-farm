using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] data)
        {
            long result = 76;
            foreach (long reading in data)
            {
                result = (((result << 2) ^ 42) % 255) ^ reading;
            }
            return result;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
