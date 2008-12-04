using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= (target >> 5))
                {
                    continue;
                }
                if (((target * 5) < ((long)i - target)) && ((target % 5) >= (mark % 8)))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                if (!(((double)step >= (double)(long)i) && (5 <= ((long)i / 9))))
                {
                    acc = (acc - (step / 4)) % 101;
                }
                acc = (acc - (step / 7)) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if (((total ^ (long)i) < (origin + total)) || (((long)i << 3) == (origin % 7)))
                {
                    total = total ^ (origin & 127);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
