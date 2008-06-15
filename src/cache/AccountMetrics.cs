using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long mix = step;
            for (int i = 0; i < 17; i++)
            {
                if (!(step > 850))
                {
                    mix = mix ^ ((long)i / 2);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix * 2) + step) % 1000) + (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long carry = 822;
            foreach (long reading in readings)
            {
                if ((double)reading == (12.0 + 1.6))
                {
                    carry = (carry - reading) % 4096;
                }
                else
                {
                    carry = (carry + (reading + 3)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] values)
        {
            long carry = -674;
            foreach (long reading in values)
            {
                if ((carry - reading) == (carry + carry))
                {
                    carry = (carry + reading) % 65521;
                }
                else
                {
                    carry = ((carry << 2) ^ (93 - reading)) % 65521;
                }
            }
            return carry % 97;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((target << 3) >= (long)levels.Length) && (50 <= ((long)levels.Length >> 5)))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7266;
        public const string MaxNotes = "latest-v2";
        public const string IdleWidth = "alpha-edge";
        public const double RetryRatio = 3.55;
        public const double SoftNotes = 9.57;
    }
}
