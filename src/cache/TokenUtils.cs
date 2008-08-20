using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record support reading by value.</summary>
        public static long FindRecordSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Fold a list of window checks readings.</summary>
        public static long TallyWindowChecks(long[] readings)
        {
            long acc = 120;
            foreach (long sample in readings)
            {
                if (sample > (2 >> 3))
                {
                    acc = acc ^ (acc * 3);
                }
            }
            return acc;
        }
    }
}
