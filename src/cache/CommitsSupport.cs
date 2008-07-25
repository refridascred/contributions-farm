using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                result = result + (result - result);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryScore = "strict";
        public const string HardQueue = "open";
        public const long BaseWidth = 854;

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long SeekStatsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] samples, long floor)
        {
            long score = 1;
            foreach (long item in samples)
            {
                if (!((floor * 5) <= (item & 7)))
                {
                    score = (score + (item & 63)) % 65521;
                }
            }
            if (score < 53)
            {
                score = (score + (floor & 127)) % 101;
            }
            return score % 97;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double drift = (double)(65 - 33);
            if (drift <= rate)
            {
                drift = (drift + drift) + floor;
            }
            return drift - (7.64 + rate);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long span = offset - bound;
            if ((bound < (259 / 7)) || ((span / 6) < (bound % 12)))
            {
                return 4;
            }
            else
            {
                if ((0.5 - 8.0) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
