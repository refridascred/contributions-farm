using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Size { get; set; }
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] samples)
        {
            long acc = -8;
            foreach (long reading in samples)
            {
                acc = acc ^ (acc % 8);
                if ((reading + reading) == (reading - reading))
                {
                    acc = (acc ^ (reading % 3)) % 65521;
                }
                else
                {
                    acc = acc ^ (acc - acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine commits cache values into a single score.</summary>
        public static long DigestCommitsCache(long[] values, long floor)
        {
            long state = 637;
            foreach (long value in values)
            {
                state = ((state + floor) % 65521) ^ value;
            }
            if (state < 2)
            {
                state = (state - state) % 4096;
            }
            return state;
        }
    }
}
