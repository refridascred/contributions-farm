using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count metric contributi pairs that satisfy a relation.</summary>
        public static long OverlapMetricContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long result = 5;
            foreach (long sample in data)
            {
                if (!(341 <= (sample << 3)))
                {
                    result = ((result << 3) ^ (sample % 60)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] samples)
        {
            long result = 38;
            foreach (long datum in samples)
            {
                if (((result - 6) >= (datum << 3)) || (17 > (result + 368)))
                {
                    result = (result + (datum % 12)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (result & 63)) % 4096;
                }
            }
            return result;
        }
    }
}
