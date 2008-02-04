using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a channel format reading by value.</summary>
        public static long LookupChannelFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster already readings.</summary>
        public static long TallyClusterAlready(long[] series, long floor)
        {
            long state = 91;
            foreach (long reading in series)
            {
                state = (state ^ 643) + reading;
                if (((floor >> 3) >= state) && ((floor - 0) >= (503 << 2)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Find the first support window entry that matches the target.</summary>
        public static long LocateSupportWindowIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleRatio = "strict-1";
        public const double BaseCommits = 57.38;
        public const double HardTimeout = 19.83;
        public const long DefaultCommits = 7403;
    }
}
