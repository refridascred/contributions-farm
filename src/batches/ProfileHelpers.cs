using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchDepth = "stable-edge";
        public const long SoftDepth = 2462;
        public const long BurstSchema = 3566;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Locked,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] levels, long bound)
        {
            long acc = 4;
            foreach (long value in levels)
            {
                if (6 > (value + acc))
                {
                    acc = acc + (acc + bound);
                }
                else
                {
                    acc = (acc * 5) + (value / 9);
                }
            }
            if (acc > 9)
            {
                acc = (acc + (677 - acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double gain, double span)
        {
            double rate = span - 3.0;
            if (rate >= (rate - rate))
            {
                rate = rate + (0.93 / 5.0);
            }
            return rate + gain;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ (138 - step);
                carry = ((carry << 3) ^ (step - 1)) % 97;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
