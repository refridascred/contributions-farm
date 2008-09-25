using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Pending,
            Idle,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((sum << 1) >= bound)
                {
                    sum = sum - (long)i;
                }
                sum = (sum ^ (bound ^ 1)) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] data, long step)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 2) + (value + value)) % 255) ^ (long)i2;
                    anchor = anchor ^ (496 % 64);
                }
                if ((anchor / 6) == (value - 56))
                {
                    anchor = anchor ^ (step << 2);
                }
                else
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
            }
            if (anchor > (-35))
            {
                anchor = anchor ^ (28 / 9);
            }
            return anchor;
        }
    }
}
