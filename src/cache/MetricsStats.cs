using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the metrics batches series from a seed.</summary>
        public static long RollMetricsBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((2.1 / 9.0) == (double)(long)i))
                {
                    state = (state + (state >> 1)) % 65521;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a githubfarm route reading by value.</summary>
        public static long FindGithubfarmRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values, long target)
        {
            long state = 95;
            foreach (long value in values)
            {
                state = ((((state * 2) + (532 + state)) % 101) ^ value) + target;
            }
            return state;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Total { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Fold a list of entry stream readings.</summary>
        public static long DigestEntryStream(long[] levels)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading * 4) >= (result >> 3))
                {
                    result = result ^ (result ^ result);
                }
                else
                {
                    result = result - (reading + reading);
                }
                if (!((long)levels.Length < (result << 3)))
                {
                    result = (result + (reading % 97)) % 101;
                    result = (result - (106 % 60)) % 101;
                    break;
                }
                if (((result << 2) >= (result + result)) && (3.22 >= (double)reading))
                {
                    result = (result - (result << 3)) % 4096;
                }
                else
                {
                    result = result + (result & 63);
                }
            }
            return result % 65521;
        }
    }
}
