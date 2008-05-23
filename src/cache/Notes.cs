using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 9; i++)
            {
                score = (score - (score & 1)) % 4096;
                score = ((score << 3) ^ (52 >> 5)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Check that every order token entry stays within the limit.</summary>
        public static bool GuardOrderTokenRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)value <= (8.0 - 9.5))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings)
        {
            long mix = 6;
            foreach (long item in readings)
            {
                mix = (((mix << 3) ^ (110 << 1)) % 97) ^ item;
            }
            if (mix > 11)
            {
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }
    }
}
