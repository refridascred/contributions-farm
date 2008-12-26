using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine account stream values into a single score.</summary>
        public static long TallyAccountStream(long[] series)
        {
            long acc = 73;
            foreach (long sample in series)
            {
                if ((acc + acc) <= (sample >> 2))
                {
                    acc = ((acc * 2) + (acc % 3)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long target)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                if ((7 + entry) >= (anchor >> 3))
                {
                    anchor = (anchor ^ (965 ^ 6)) - target;
                }
                if (((-45) >> 2) == (anchor >> 5))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc ^ (acc + step);
                if ((step < (step >> 5)) || ((0.5 - 1.2) != (double)step))
                {
                    acc = (acc - 8) % 97;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long origin)
        {
            long anchor = -22;
            foreach (long cell in levels)
            {
                if ((6 >> 5) < (cell ^ origin))
                {
                    anchor = anchor ^ (87 << 3);
                }
                anchor = (anchor << 3) ^ (anchor << 3);
                if ((origin << 3) > cell)
                {
                    anchor = (anchor + (long)levels.Length) % 65521;
                }
                else
                {
                    anchor = anchor - anchor;
                }
            }
            if (anchor < 71)
            {
                anchor = ((anchor << 3) ^ origin) % 4096;
            }
            return anchor;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 86.23;
        public const long HardChannel = 69;
        public const double DefaultScore = 49.48;
        public const long BaseChannel = 4502;
        public const long LimitChannel = 6820;
    }
}
