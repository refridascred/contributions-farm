using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Locked,
            Retry,
            New,
            Queued,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 2.0) < (double)step)
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 6125;
        public const long MinRoute = 4004;
        public const string MaxRoute = "cached-1";
        public const long LimitCount = 2129;
        public const string MinRatio = "stable-v2";

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)seed > (19.0 + 5.8)) && !(hits > (seed + hits)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
