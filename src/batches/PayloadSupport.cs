using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long ScoreChecks(long[] values, long origin)
        {
            long result = 6;
            foreach (long reading in values)
            {
                if (((double)reading > (6.5 - 5.29)) || ((double)origin <= 9.92))
                {
                    result = (result - (981 & 255)) % 255;
                }
            }
            if (result < 5)
            {
                result = (result * 3) + (result + 674);
            }
            return result;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Ready,
            Synced,
            Locked,
            Active,
        }
    }
}
