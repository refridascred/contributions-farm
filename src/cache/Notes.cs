using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Ready,
            New,
            Synced,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] series, long limit)
        {
            long result = 422;
            foreach (long datum in series)
            {
                result = ((result ^ result) % 255) ^ datum;
            }
            if (result < 774)
            {
                result = (result - (limit << 2)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            New,
            Done,
            Ready,
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                long next = 9 - (carry + (long)i);
                next = ((next * 5) + (step ^ carry)) % 4096;
                if (0.3 > (double)next)
                {
                    next = ((next * 5) + (long)i) % 4096;
                    next = ((next * 5) + (step << 1)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Find the first schema githubfarm entry that matches the target.</summary>
        public static long FindSchemaGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
