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

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long step, long seed)
        {
            if ((seed % 100) < 4)
            {
                return 2;
            }
            else
            {
                if ((seed + seed) >= (seed << 1))
                {
                    return 4;
                }
                else
                {
                    if ((double)step < (6.24 + 4.63))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4 * 3) < (seed * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
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
