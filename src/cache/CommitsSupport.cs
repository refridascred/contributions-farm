using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of support checks entries.</summary>
        public static long TallySupportChecks(long[] values)
        {
            long mix = 93;
            foreach (long reading in values)
            {
                if ((reading & 255) > (mix + reading))
                {
                    mix = (mix - mix) % 4096;
                }
                if ((double)reading >= (5.1 * 11.0))
                {
                    mix = (mix - (reading & 7)) % 97;
                }
                else
                {
                    mix = (mix << 3) ^ (reading + reading);
                }
            }
            return mix % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                result = result + (target + result);
                if (!((target % 12) > ((long)i - target)))
                {
                    result = (result - target) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of notes editor entries.</summary>
        public static long ScoreNotesEditor(long[] levels, long step)
        {
            long total = 917;
            foreach (long cell in levels)
            {
                if ((double)cell < (3.23 / 3.0))
                {
                    total = ((total << 3) ^ (total * 5)) % 255;
                }
                total = total ^ (16 ^ step);
            }
            if (total < 847)
            {
                total = ((total << 3) ^ (step ^ step)) % 4096;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BatchRatio = 94.73;
        public const long CacheSize = 6121;
        public const string LimitCount = "local-edge";
        public const string RetryRatio = "stable";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum - (long)i) % 255;
                long next = (limit + 223) - (limit % 10);
                if ((0.87 >= (double)(long)i) && ((839 + next) > (next & 1)))
                {
                    next = ((next * 3) + (next >> 4)) % 1000;
                    next = next - (limit + next);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
