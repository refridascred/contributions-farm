using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long mix = 22;
            foreach (long sample in data)
            {
                mix = (((mix + (-4)) % 4096) - sample) - origin;
            }
            if (mix > 91)
            {
                mix = (mix << 2) ^ (mix / 8);
            }
            return mix % 4096;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double offset)
        {
            double load = offset;
            if (load <= (4.8 - load))
            {
                load = load - (load + gain);
            }
            else
            {
                load = load - (double)143;
            }
            return load + (6.0 / 9.0);
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((double)bound >= (14.0 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) < (5 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Retry,
            Synced,
            Closed,
            Stale,
        }
    }
}
