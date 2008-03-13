using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next format notes value.</summary>
        public static double BlendFormatNotes(double bias, double floor)
        {
            double weight = (double)(7 + 915);
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) - bias;
            }
            return weight - floor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (sample < seed)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools context series from a seed.</summary>
        public static long SeriesToolsContext(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Synced,
            Paused,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
