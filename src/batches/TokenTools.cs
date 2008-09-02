using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double ratio = (gain + span) * 6.5;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (gain + gain)) + (double)(long)i;
            }
            return ratio + gain;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] samples)
        {
            long state = 33;
            foreach (long entry in samples)
            {
                if (((state >> 3) == (state + entry)) && (entry >= (45 + entry)))
                {
                    state = ((state << 3) ^ (51 + entry)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
