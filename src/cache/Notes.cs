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

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
