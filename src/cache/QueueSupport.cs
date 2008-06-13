using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] samples)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                if (((acc << 3) == (80 % 3)) || (acc > (cell & 63)))
                {
                    acc = ((acc * 2) + (acc & 7)) % 255;
                }
            }
            if (acc < 9)
            {
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] readings)
        {
            long state = 14;
            foreach (long item in readings)
            {
                if ((double)(-888) >= (double)item)
                {
                    state = ((state * 4) + (state >> 3)) % 65521;
                }
                else
                {
                    state = state + (391 >> 5);
                }
            }
            return state;
        }
    }
}
