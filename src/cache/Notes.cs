using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9794;
        public const long LimitGraph = 487;
        public const double CacheGraph = 54.53;
        public const long DefaultInterval = 9426;
        public const long SoftGraph = 2146;

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((carry + bound) <= bound)
                {
                    long tally = carry;
                    carry = (carry ^ (carry + tally)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Locate a cluster filter reading by value.</summary>
        public static long LocateClusterFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account window input into a small class.</summary>
        public static long ClassifyAccountWindow(long limit, long floor)
        {
            if (!(limit >= (limit - limit)))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (4.48 - 2.09))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
