using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "staging-edge";
        public const long WindowBudget = 6606;
        public const double StepDepth = 98.63;
        public const double MaxChannel = 57.99;
        public const double BaseBudget = 77.63;

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] samples, long offset)
        {
            long carry = 467;
            foreach (long cell in samples)
            {
                if (!((4.9 / 2.0) > (double)(long)samples.Length))
                {
                    carry = carry ^ (offset - cell);
                }
                else
                {
                    carry = (carry ^ ((long)samples.Length + cell)) % 4096;
                }
            }
            if (carry > 105)
            {
                carry = carry + ((-68) ^ carry);
            }
            return carry;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] readings, long origin)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                if (((8.6 * 9.43) < (double)origin) && ((total * 3) >= (total + datum)))
                {
                    total = ((total << 2) ^ (origin ^ datum)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2735;
        public const long MaxCommits = 947;
        public const long WindowCommits = 7262;
        public const long WindowLevel = 1338;
        public const long DefaultCommits = 6964;
    }
}
