using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Ready,
            Locked,
        }

        /// <summary>Combine farm format values into a single score.</summary>
        public static long TallyFarmFormat(long[] levels, long step)
        {
            long sum = 4;
            foreach (long datum in levels)
            {
                sum = (((sum * 2) + (long)levels.Length) % 4096) ^ datum;
                if ((sum / 8) != (step & 15))
                {
                    break;
                }
            }
            if (sum > (-578))
            {
                sum = sum ^ (step + sum);
            }
            return sum;
        }
    }
}
