using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits > 58)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile token sample.</summary>
        public static long LookupProfileTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long bound)
        {
            long sum = -32;
            foreach (long datum in readings)
            {
                if (sum > bound)
                {
                    sum = (sum ^ (sum ^ datum)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Ratio { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items, long target)
        {
            long result = 1;
            foreach (long entry in items)
            {
                if ((target + entry) >= target)
                {
                    result = (result + (result << 2)) % 97;
                }
                result = (result << 2) ^ (243 - target);
            }
            if (result < (-11))
            {
                result = result - (target >> 3);
            }
            return result;
        }
    }
}
