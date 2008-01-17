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

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
