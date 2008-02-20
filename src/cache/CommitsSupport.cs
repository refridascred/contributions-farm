using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftScore = 1453;
        public const long MinWidth = 1524;
        public const long WindowChecks = 6594;
        public const double IdleScore = 97.5;

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (drift - offset))
            {
                drift = (drift - (offset + 6.46)) - ratio;
            }
            else
            {
                drift = drift - (offset * 8.77);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)563) + (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum & 127) >= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
