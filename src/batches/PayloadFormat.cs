using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (cell < (matches % 60))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Active,
            Queued,
        }
    }
}
