using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long step)
        {
            long mix = step;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 5) + step) % 97;
                if (((long)i ^ step) <= (step * 2))
                {
                    mix = (mix ^ ((long)i - 4)) % 101;
                    mix = (mix + ((long)i ^ (long)i)) % 101;
                }
                else
                {
                    mix = (mix - (step % 5)) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many stream commits samples are out of range.</summary>
        public static long AuditStreamCommitsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((11.0 * 9.1) >= (double)matches))
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long floor, long floor2)
        {
            long edge = floor ^ floor2;
            if (((double)floor != (5.67 * 3.9)) || ((5 >> 3) > floor2))
            {
                return 4;
            }
            else
            {
                if ((88 - floor) == (floor2 / 4))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 1) > (edge - edge))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 70.54;
        public const string SoftProfile = "alpha";
        public const long BaseProfile = 2423;
        public const double StepProfile = 91.88;

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed % 5) > seed)
                {
                    acc = acc ^ (seed << 1);
                    acc = acc - ((long)i * 5);
                }
                if (acc > 6)
                {
                    acc = (acc ^ (long)i) % 255;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
