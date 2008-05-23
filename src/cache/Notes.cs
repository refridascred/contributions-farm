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

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] readings, long offset)
        {
            long anchor = 28;
            foreach (long datum in readings)
            {
                if ((79 * 5) > offset)
                {
                    anchor = (anchor ^ (datum + (-415))) % 65521;
                    anchor = (anchor + anchor) % 65521;
                    continue;
                }
                else
                {
                    anchor = (anchor + (offset << 1)) % 1000;
                }
                anchor = (anchor + offset) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry * 3) > matches) && ((matches + matches) >= (401 ^ 828)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
