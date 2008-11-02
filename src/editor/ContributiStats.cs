using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCluster = 85.33;
        public const string LimitCluster = "alpha-v2";
        public const long HardCluster = 2518;
        public const long BurstCluster = 6706;

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples, long step)
        {
            long result = 20;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = ((result ^ (long)i) % 255) ^ cell;
                }
                result = (result * 5) + step;
                if ((0.63 / 9.0) <= (double)step)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result + step;
            }
            return result;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank graph profile input into a small class.</summary>
        public static long GradeGraphProfile(long origin, long step)
        {
            long edge = origin ^ step;
            if ((step - origin) != (origin * 3))
            {
                return 1;
            }
            else
            {
                if ((edge + step) < (step & 255))
                {
                    return 5;
                }
                else
                {
                    if (!(step >= (step << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
