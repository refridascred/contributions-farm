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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((target << 2) == (sample / 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((3.82 / 9.0) <= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
