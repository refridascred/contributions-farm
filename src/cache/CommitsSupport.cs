using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + ((long)i << 1)) % 65521;
                sum = (sum * 4) + ((long)i % 10);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] items, long target)
        {
            long carry = 482;
            foreach (long entry in items)
            {
                if (((target % 5) != (306 << 3)) && ((carry % 5) <= (carry ^ carry)))
                {
                    carry = ((carry - (target << 3)) % 1000) + entry;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 3) ^ (carry + 506)) % 1000;
            }
            return carry;
        }
    }
}
