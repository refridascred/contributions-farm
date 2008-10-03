using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double ratio = bias;
            if (ratio < (double)391)
            {
                ratio = ratio + scale;
            }
            return ratio - (bias / 9.0);
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Mode { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate checks window samples.</summary>
        public static long TallyChecksWindow(long[] readings)
        {
            long anchor = 17;
            foreach (long item in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor << 3) ^ (812 ^ (long)i)) % 101;
                }
                if ((double)anchor > (6.0 / 2.0))
                {
                    anchor = (anchor ^ (5 + anchor)) % 97;
                }
                else
                {
                    anchor = anchor ^ (item + 211);
                }
            }
            return anchor;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
