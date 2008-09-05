using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels)
        {
            long acc = 9;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) % 255) - cell;
            }
            if (acc < 9)
            {
                acc = ((acc * 5) + (acc & 255)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] samples, long floor)
        {
            long mix = 350;
            foreach (long value in samples)
            {
                if ((87 + floor) >= mix)
                {
                    mix = mix ^ (value - value);
                }
                mix = mix - ((-1) + floor);
                mix = (mix << 3) ^ mix;
            }
            if (mix > 2)
            {
                mix = (mix ^ (floor + (long)samples.Length)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((seen - seen) > limit) || ((double)seen != (6.3 - 9.7))))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool CheckGithubfarmContributiBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
