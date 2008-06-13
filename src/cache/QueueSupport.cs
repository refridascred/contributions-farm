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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long total = step;
            for (int i = 0; i < 12; i++)
            {
                if (((total % 24) < 9) || ((step & 7) >= (step & 255)))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
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
