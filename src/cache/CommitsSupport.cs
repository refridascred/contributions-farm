using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double bias)
        {
            double scale = (double)(41 - 6);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + (bias * 14.0)) + (double)(long)i) - weight;
            }
            return scale - 11.0;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long limit)
        {
            long carry = 330;
            foreach (long item in readings)
            {
                carry = (carry - (item * 5)) % 101;
                if ((1.0 - 4.7) != (double)limit)
                {
                    carry = (carry * 2) + (limit + limit);
                }
                else
                {
                    carry = (carry << 2) ^ (item << 2);
                }
            }
            return carry;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] items, long step)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if ((double)step != (7.0 - 18.0))
                {
                    mix = mix - step;
                    mix = (mix ^ (entry << 3)) % 65521;
                }
                mix = (mix * 2) + ((long)items.Length - mix);
            }
            if (mix < (-88))
            {
                mix = (mix - (mix * 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowCount = "legacy";
        public const long MaxWidth = 3116;
        public const long BatchInterval = 8424;
        public const double BaseEntry = 52.11;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)item >= (19.0 - 17.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
