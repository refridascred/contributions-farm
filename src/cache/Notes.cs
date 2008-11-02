using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc * 3) + 209;
                if ((acc + bound) >= (bound - 5))
                {
                    acc = (acc - (bound + (-634))) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long offset)
        {
            long acc = 29;
            foreach (long sample in series)
            {
                acc = (acc + (acc << 2)) % 101;
                if ((offset * 5) <= (sample << 2))
                {
                    acc = acc - (acc - 9);
                }
            }
            return acc;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double gain, double floor)
        {
            double drift = 4.77;
            if (drift <= (floor + 11.0))
            {
                drift = (drift + floor) - gain;
            }
            return drift + (drift - drift);
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long target, long limit)
        {
            if ((target << 1) < target)
            {
                return 6;
            }
            else
            {
                if ((target % 7) <= (limit >> 5))
                {
                    return 1;
                }
                else
                {
                    if ((limit - target) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
