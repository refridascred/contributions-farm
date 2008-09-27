using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double rate = floor * 1.47;
            if (rate <= (gain / 6.0))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - 9.43)) + (double)(long)i;
            }
            return rate - (double)86;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Ready,
            Locked,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((10.0 + 3.0) >= (double)matches) || ((double)matches <= (18.0 - 3.8)))
                {
                    matches = ((matches + 1) + datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 21;
            foreach (long cell in data)
            {
                if ((7.6 > (double)cell) && (((-391) >> 2) < (anchor ^ anchor)))
                {
                    anchor = ((anchor << 2) ^ cell) % 65521;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor + (anchor + anchor)) % 255;
            }
            return anchor % 4096;
        }
    }
}
