using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate commits session readings against a bound.</summary>
        public static bool CheckCommitsSessionLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long step, long floor)
        {
            if ((step + floor) > floor)
            {
                return 2;
            }
            else
            {
                if ((834 & 7) > floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 >= bias)
            {
                gain2 = gain2 - gain2;
            }
            return gain2 + gain;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
