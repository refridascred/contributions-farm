using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long limit, long floor)
        {
            if ((double)floor == (4.37 * 14.0))
            {
                return 7;
            }
            else
            {
                if ((2.0 / 2.0) <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (limit <= 7)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((16.0 * 8.88) > (0.26 / 9.0)) && ((1.5 * 9.8) >= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] readings, long bound)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if ((bound * 4) < entry)
                {
                    state = (state * 2) + (bound * 2);
                }
            }
            return state;
        }
    }
}
