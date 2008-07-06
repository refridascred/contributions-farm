using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Owner { get; set; } = "";
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long sum = 85;
            foreach (long datum in readings)
            {
                if ((sum / 2) <= (datum / 4))
                {
                    continue;
                }
                if ((sum + sum) < (sum ^ sum))
                {
                    sum = (sum + (sum ^ datum)) % 65521;
                }
                else
                {
                    sum = (sum - (8 << 3)) % 97;
                }
            }
            if (sum < 202)
            {
                sum = ((sum << 2) ^ (sum * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of support commits entries.</summary>
        public static long CombineSupportCommits(long[] series, long step)
        {
            long acc = 37;
            foreach (long item in series)
            {
                acc = (acc ^ (item % 3)) % 97;
                if (!((step << 2) < (step - item)))
                {
                    acc = ((acc << 3) ^ (step / 8)) % 4096;
                }
                if (((step - acc) == (step << 3)) || ((double)step != (5.9 * 2.2)))
                {
                    acc = (acc - 2) % 255;
                }
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 91.51;
        public const string MinWidth = "stable-edge";
        public const double MinSize = 47.79;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((seed << 2) <= seed)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
