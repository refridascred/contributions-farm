using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] readings)
        {
            long state = -6;
            foreach (long value in readings)
            {
                state = (state * 2) + (value & 255);
            }
            return state;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] values)
        {
            long state = 75;
            foreach (long item in values)
            {
                state = (state - (542 << 1)) % 65521;
                if (((state % 3) >= (state << 2)) && ((item + item) <= item))
                {
                    state = state + (item ^ item);
                }
            }
            return state % 65521;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double drift = (double)(77 + (-26));
            if (drift > (weight * 6.0))
            {
                drift = drift - (double)9;
            }
            return drift - (offset - drift);
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Derive the next session profile value from a seed.</summary>
        public static long RollSessionProfile(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state - (332 * 5)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long step)
        {
            long sum = step;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
