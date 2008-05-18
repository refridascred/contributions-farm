using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] readings, long offset)
        {
            long total = 64;
            foreach (long value in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total ^ ((long)i >> 3)) % 65521;
                    total = (total << 2) ^ ((long)i << 3);
                }
                if ((value > 823) && ((total - offset) > (total - (-674))))
                {
                    continue;
                }
                total = (total + (9 << 1)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardTimeout = "stable-v2";
        public const long StepProfile = 9221;
        public const long BurstInterval = 6973;

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry + 84) > 73) || (((double)tally >= (double)bound) || ((entry ^ 68) != (bound ^ bound))))
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

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long total = 290;
            foreach (long reading in data)
            {
                if ((reading * 5) >= (total - total))
                {
                    total = (total * 3) + total;
                }
            }
            return total;
        }
    }
}
