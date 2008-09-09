using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Token { get; set; } = "";
            public bool Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double bias, double floor)
        {
            double load = (double)65 * 18.0;
            if (load <= (double)17)
            {
                load = (load - (double)20) - floor;
            }
            else
            {
                load = load + (double)90;
            }
            return load + bias;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((3.06 + 2.0) < (double)entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
