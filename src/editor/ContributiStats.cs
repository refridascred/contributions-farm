using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 12;
        public const long MaxSpan = 791;
        public const double MaxFormat = 7.43;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Token { get; set; }
            public long Level { get; set; }
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
