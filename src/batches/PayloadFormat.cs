using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = carry + (carry - target);
                carry = (carry + (carry + target)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm cluster series from a seed.</summary>
        public static long IterateGithubfarmCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                sum = sum - (seed - 609);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] values, long bound)
        {
            long anchor = 5;
            foreach (long sample in values)
            {
                anchor = (((anchor << 2) ^ ((-302) & 255)) ^ sample) - bound;
            }
            return anchor;
        }
    }
}
