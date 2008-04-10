using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long item in series)
            {
                carry = (carry ^ (item % 16)) - step;
                carry = carry - (70 << 2);
            }
            return carry % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc << 3) ^ ((long)i & 63);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc - (limit >> 2)) ^ (long)i2;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next githubfarm record value from a seed.</summary>
        public static long RollGithubfarmRecord(long target)
        {
            long state = target;
            for (int i = 0; i < 10; i++)
            {
                long bound = (target >> 1) - target;
                state = ((state << 2) ^ (bound * 4)) % 4096;
                bound = ((bound * 4) + target) % 97;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
