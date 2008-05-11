using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long StepPayloadAlready(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (638 & 255);
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (((acc * 3) + ((long)i << 3)) % 97) + (long)i2;
                    acc = (acc * 4) + (acc % 64);
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 22; i++)
            {
                mark = (mark - (offset / 8)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long target, long offset)
        {
            long step = target - offset;
            if (((offset ^ step) == (step % 10)) || (2.99 <= (double)target))
            {
                return 5;
            }
            else
            {
                if ((step + offset) > offset)
                {
                    return 1;
                }
                else
                {
                    if (!((offset + step) < (target / 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset & 255) != (target >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Draft,
            Ready,
        }
    }
}
