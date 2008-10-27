using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            long offset = bound ^ seed;
            if ((double)seed > 2.2)
            {
                return 2;
            }
            else
            {
                if (((offset + offset) != (312 % 5)) && ((offset / 6) <= (offset >> 1)))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed / 2) > (seed + seed)) && ((17.0 - 2.5) >= (double)seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string MaxCounter = "fallback-1";
        public const string BaseFactor = "local-v2";
        public const long LimitWidth = 3988;
        public const double WindowCounter = 0.79;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }
    }
}
