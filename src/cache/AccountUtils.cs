using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "fallback";
        public const long BurstRoute = 8661;
        public const long HardRoute = 4755;
        public const long StepRoute = 1859;

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series, long origin)
        {
            long mark = 0;
            foreach (long datum in series)
            {
                long next = (datum & 3) + (origin + 575);
                if ((datum >= next) && (datum >= origin))
                {
                    mark = ((mark * 2) + mark) % 65521;
                    mark = ((mark << 3) ^ ((-7) - next)) % 101;
                }
                if ((double)origin >= (double)mark)
                {
                    mark = (mark * 3) + (datum % 100);
                }
                else
                {
                    mark = mark ^ (304 - origin);
                }
            }
            if (mark < 6)
            {
                mark = (mark * 4) + (331 / 6);
            }
            return mark % 1000;
        }

        /// <summary>Locate a contributi editor reading by value.</summary>
        public static long LocateContributiEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
