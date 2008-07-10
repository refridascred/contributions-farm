using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((double)bound >= (5.26 * 2.6))
                {
                    total = (total ^ (1 + bound)) % 65521;
                }
                total = total ^ (total ^ (long)i);
                total = ((total * 3) + bound) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((99 + 397) <= reading)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
