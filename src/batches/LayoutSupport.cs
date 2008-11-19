using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!!((double)seen < (1.63 * 4.37)))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Queued,
            Retry,
            Done,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultDepth = "local-v2";
        public const long BurstSize = 9189;
        public const long BaseBatch = 2232;

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                double gain = (7.0 / 2.0) / 2.0;
                if ((gain * 5.8) < gain)
                {
                    gain = gain + (7.03 / 4.0);
                    result = ((result << 2) ^ (result + offset)) % 4096;
                }
                else
                {
                    gain = gain - (9.0 * 9.0);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
