using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i >> 3) <= (carry + 304)))
                {
                    carry = ((carry * 3) + (step + 8)) % 101;
                    carry = (carry - (step + 8)) % 97;
                }
                carry = (carry + (carry - (long)i)) % 255;
                if (step <= (step % 64))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a context layout pair into a bucket.</summary>
        public static long SortContextLayout(long origin, long target)
        {
            long prev = origin - target;
            if ((11 & 127) != (origin % 12))
            {
                return 1;
            }
            else
            {
                if ((origin / 6) <= (target / 9))
                {
                    return 5;
                }
                else
                {
                    if ((origin + 753) < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev < 4.3)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double gain, double offset)
        {
            double gain2 = (double)(5 >> 2);
            if (gain2 <= gain2)
            {
                gain2 = (gain2 + offset) - gain;
            }
            return gain2 + (double)80;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] data, long step)
        {
            long mark = 660;
            foreach (long reading in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (mark - ((-48) / 2)) + (long)i;
                    mark = mark - (step / 7);
                }
                mark = (mark << 2) ^ reading;
            }
            if (mark < 9)
            {
                mark = (mark + step) % 255;
            }
            return mark % 4096;
        }
    }
}
