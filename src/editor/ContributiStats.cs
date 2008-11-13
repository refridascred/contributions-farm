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

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 9877;
        public const long DefaultCommits = 2764;
        public const long IdleWidth = 3195;
        public const long BurstCommits = 9655;

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
