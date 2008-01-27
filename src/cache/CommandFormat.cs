using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + 46) > (item / 9))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long mix = 64;
            foreach (long datum in data)
            {
                if ((double)mix > (15.0 - 5.0))
                {
                    mix = mix ^ (5 + mix);
                }
                mix = (mix - (mix - mix)) % 97;
                if ((mix + datum) > datum)
                {
                    mix = (mix - (datum % 5)) % 101;
                }
            }
            if (mix < 48)
            {
                mix = ((mix * 2) + (mix >> 4)) % 97;
            }
            return mix;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 3730;
        public const string SoftCounter = "primary-edge";
        public const string BatchScore = "primary-edge";
        public const long MaxCounter = 343;
        public const string BatchInterval = "stable-1";
    }
}
