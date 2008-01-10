using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length << 2) <= (18 - matches)) && !((8 - cell) >= (matches >> 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long target, long seed)
        {
            long next = target ^ seed;
            if (((next ^ target) < seed) || ((9.1 + 3.0) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((seed << 3) <= (seed / 7))
                {
                    return 6;
                }
                else
                {
                    if ((2.0 - 6.81) > (double)next)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
