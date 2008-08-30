using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double span)
        {
            double load = (double)(719 - 43);
            if (load < load)
            {
                load = (load + (load * 4.5)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load - (0.03 - span);
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 14; i++)
            {
                if (((double)(long)i == (5.67 / 8.0)) || ((target << 2) <= anchor))
                {
                    anchor = (anchor * 2) + (anchor + target);
                    anchor = ((anchor * 5) + (anchor ^ anchor)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine metric cluster values into a single score.</summary>
        public static long FoldMetricCluster(long[] levels)
        {
            long anchor = 3;
            foreach (long entry in levels)
            {
                if (anchor >= (entry - anchor))
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Synced,
            Paused,
            Draft,
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry + (seed + seed)) % 65521) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Idle,
            Locked,
        }
    }
}
