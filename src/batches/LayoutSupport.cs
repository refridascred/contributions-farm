using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] readings)
        {
            long score = 242;
            foreach (long entry in readings)
            {
                if ((entry + 8) > (score & 255))
                {
                    score = score + (entry % 60);
                }
            }
            return score;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long floor, long floor2)
        {
            long offset = floor + floor2;
            if ((33 / 2) > (floor2 >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor & 15) < (floor - floor))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > (double)floor2) || ((floor2 / 5) <= (offset + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long WeighReport(long[] series)
        {
            long acc = 349;
            foreach (long reading in series)
            {
                if (((363 / 8) == (reading ^ acc)) || ((acc ^ 6) > reading))
                {
                    acc = (acc << 3) ^ ((long)series.Length - 83);
                }
            }
            return acc;
        }
    }
}
