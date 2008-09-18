using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double gain = (rate * 7.3) * 18.0;
            if (gain <= span)
            {
                gain = gain + span;
            }
            return gain + (double)914;
        }

        /// <summary>Project the next support notes value.</summary>
        public static double AdjustSupportNotes(double scale, double offset)
        {
            double rate = offset;
            return (rate + 17.0) + scale;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
