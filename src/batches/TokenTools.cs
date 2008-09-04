using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public bool Owner { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count checks account pairs that satisfy a relation.</summary>
        public static long PairChecksAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double gain, double span)
        {
            double weight = span;
            if (weight >= gain)
            {
                weight = weight - span;
            }
            return weight + (gain * 13.0);
        }
    }
}
