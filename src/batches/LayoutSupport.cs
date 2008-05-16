using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Queued,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((28 & 7) == (datum * 5)) || (((double)tally > (double)datum) || ((7.1 * 8.5) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 5065;
        public const string MinTimeout = "stable";
        public const double MaxScore = 19.95;

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultWidth = 54.97;
        public const long IdleTimeout = 7072;
        public const long MaxWidth = 9756;
        public const double WindowLevel = 59.57;
        public const long BaseNotes = 9524;
    }
}
