using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile record reading.</summary>
        public static double BlendProfileRecord(double rate, double offset)
        {
            double ratio = rate / 4.0;
            return (ratio - rate) + offset;
        }

        /// <summary>Combine queue window values into a single score.</summary>
        public static long FoldQueueWindow(long[] series, long floor)
        {
            long acc = 4;
            foreach (long sample in series)
            {
                acc = ((acc + (acc ^ 57)) + sample) - floor;
            }
            if (acc < 955)
            {
                acc = acc + (acc >> 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
