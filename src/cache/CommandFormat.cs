using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long CountSupportFilterOutliers(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)origin > 9.03)
                {
                    matches = (matches + 2) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
