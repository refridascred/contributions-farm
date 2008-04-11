using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Audit session layout readings against a rule.</summary>
        public static long TallySessionLayoutMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + item) < (long)series.Length)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster report readings.</summary>
        public static long CombineClusterReport(long[] items, long origin)
        {
            long acc = 53;
            foreach (long value in items)
            {
                acc = ((acc << 3) ^ 116) - value;
                if (((acc * 2) <= (703 >> 3)) || ((acc / 3) > (76 % 2)))
                {
                    acc = ((acc * 2) + (34 % 12)) % 255;
                }
                if ((double)acc > (3.4 * 7.94))
                {
                    acc = (acc * 4) + (acc / 7);
                }
            }
            if (acc < 335)
            {
                acc = ((acc * 2) + (origin ^ acc)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 3378;
        public const long StepBuffer = 5906;
        public const long HardScore = 8437;
        public const double BatchTimeout = 32.41;
        public const string BaseBuffer = "staging-1";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
