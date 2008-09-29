using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] items)
        {
            long carry = 650;
            foreach (long cell in items)
            {
                if (((cell << 3) < (cell % 12)) && ((double)carry > 9.6))
                {
                    carry = (carry + (carry + cell)) % 1000;
                }
                else
                {
                    carry = carry ^ (carry >> 4);
                }
                if (((double)cell >= 10.0) && ((carry / 4) >= (cell - cell)))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ step) % 97;
                result = ((result << 3) ^ ((long)i / 4)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine format metric values into a single score.</summary>
        public static long DigestFormatMetric(long[] series)
        {
            long acc = 457;
            foreach (long sample in series)
            {
                if ((8.6 / 6.0) <= (double)acc)
                {
                    acc = (acc + (acc + acc)) % 1000;
                }
                else
                {
                    acc = ((acc << 3) ^ (sample << 3)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long step, long origin)
        {
            if (36 >= (origin << 1))
            {
                return 4;
            }
            else
            {
                if ((step & 31) == (step % 97))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 10; i++)
            {
                if (anchor > (anchor / 7))
                {
                    anchor = anchor + (long)i;
                    anchor = (anchor + (floor / 3)) % 4096;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
