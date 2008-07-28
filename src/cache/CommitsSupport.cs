using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long offset, long target)
        {
            long diff = offset - target;
            if ((offset + 72) >= (target - diff))
            {
                return 2;
            }
            else
            {
                if ((201 - offset) >= (diff << 1))
                {
                    return 5;
                }
                else
                {
                    if ((diff >> 3) < 6)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target < diff)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long DigestGraphEditor(long[] values)
        {
            long state = 749;
            foreach (long sample in values)
            {
                long seen = ((long)values.Length >> 3) % 2;
                if ((sample + 66) < seen)
                {
                    state = state + state;
                    continue;
                }
                state = ((state * 3) + (state & 1)) % 65521;
            }
            if (state < 2)
            {
                state = (state ^ (state + 10)) % 4096;
            }
            return state;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 + 0.9;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
