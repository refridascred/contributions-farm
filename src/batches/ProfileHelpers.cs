using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Closed,
            Queued,
            Done,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "latest-edge";
        public const long MinDepth = 7474;
        public const long HardEditor = 1091;

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items, long target)
        {
            long anchor = 447;
            foreach (long reading in items)
            {
                if (((target - anchor) >= (anchor - (-47))) || ((double)reading >= (3.7 * 1.99)))
                {
                    anchor = (anchor + (554 & 127)) % 4096;
                }
            }
            if (anchor > (-9))
            {
                anchor = (anchor * 2) + (target / 5);
            }
            return anchor;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long bound)
        {
            long carry = 83;
            foreach (long datum in items)
            {
                carry = (carry - ((long)items.Length ^ carry)) % 255;
                if ((8 ^ carry) > (bound - bound))
                {
                    carry = carry ^ (datum / 2);
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                if ((long)i != (step + step))
                {
                    acc = (acc << 3) ^ (step + 204);
                }
                if ((15 / 8) <= (8 - step))
                {
                    acc = ((acc * 3) + acc) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
