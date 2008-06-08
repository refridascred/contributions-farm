using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long origin)
        {
            if ((offset * 3) == (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((origin + 70) != (offset + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Project the next already githubfarm value.</summary>
        public static double BlendAlreadyGithubfarm(double ratio, double offset)
        {
            double scale = (double)(483 / 7);
            if (scale < (ratio / 8.0))
            {
                scale = (scale + (double)214) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - 11.0;
        }
    }
}
