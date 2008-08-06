using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of support editor readings.</summary>
        public static long TallySupportEditor(long[] data, long origin)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                long bound = sample;
                sum = ((sum * 4) + (bound + sum)) - origin;
                sum = ((sum * 3) + (sum / 5)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    sum = ((sum + ((long)i + sum)) % 1000) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long step)
        {
            long state = 72;
            foreach (long sample in samples)
            {
                if (((long)samples.Length - 955) < state)
                {
                    state = (state * 2) + sample;
                }
                if ((step / 2) != (step % 8))
                {
                    state = (state + (state + 2)) % 255;
                }
            }
            return state % 1000;
        }
    }
}
