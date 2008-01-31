using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long CountFarmFormatGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (((offset ^ seen) != (4 + sample)) && ((offset & 7) > (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if (!(floor >= 7))
                {
                    total = (total - (3 >> 3)) % 255;
                }
                total = (total ^ (8 * 2)) % 97;
                total = ((total * 5) + (total + floor)) % 101;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
