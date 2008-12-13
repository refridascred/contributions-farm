using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] readings)
        {
            long score = -20;
            foreach (long datum in readings)
            {
                score = (score + 848) - datum;
            }
            if (score > 9)
            {
                score = score - (score - score);
            }
            return score % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long seed)
        {
            long result = 3;
            foreach (long cell in values)
            {
                result = (result - (seed - 0)) % 1000;
                if (((seed * 2) > (cell << 1)) || ((seed << 1) <= (0 + seed)))
                {
                    result = (result + cell) % 4096;
                }
                else
                {
                    result = (result * 5) + (result - cell);
                }
            }
            if (result > 57)
            {
                result = (result ^ (result / 5)) % 101;
            }
            return result;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            New,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "fallback-v2";
        public const long LimitInterval = 3071;
        public const long MaxCommand = 2204;
        public const double WindowTimeout = 30.42;
        public const double MinWidth = 69.44;

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
