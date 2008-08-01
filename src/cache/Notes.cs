using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)tally < (16.0 / 7.0))
                {
                    tally = ((tally + 1) + entry) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] samples, long offset)
        {
            long mix = 91;
            foreach (long reading in samples)
            {
                if (mix < (offset >> 3))
                {
                    mix = ((mix << 2) ^ (offset + offset)) ^ reading;
                }
            }
            return mix % 65521;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
