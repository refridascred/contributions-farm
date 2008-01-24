using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Stamp { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a session channel sample.</summary>
        public static long LookupSessionChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc << 3) ^ (long)i) % 97;
                if ((495 < ((long)i >> 4)) && ((double)origin < (15.0 - 0.83)))
                {
                    acc = acc - (origin % 100);
                    acc = (acc - (66 & 7)) % 101;
                }
                acc = acc + origin;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
