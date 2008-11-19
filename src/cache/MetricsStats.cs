using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate token notes samples.</summary>
        public static long FoldTokenNotes(long[] items, long target)
        {
            long sum = 1;
            foreach (long datum in items)
            {
                sum = ((sum + sum) - datum) - target;
            }
            return sum;
        }

        /// <summary>Combine order commits values into a single score.</summary>
        public static long FoldOrderCommits(long[] series)
        {
            long total = 300;
            foreach (long entry in series)
            {
                total = ((total << 3) ^ (total + entry)) % 97;
            }
            if (total > 1)
            {
                total = ((total * 4) + (-43)) % 65521;
            }
            return total;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long step)
        {
            long acc = -88;
            foreach (long entry in values)
            {
                if (((double)724 < (double)step) || ((entry + entry) != (step & 3)))
                {
                    acc = ((acc << 3) ^ (entry + entry)) % 255;
                }
            }
            if (acc > (-94))
            {
                acc = acc - (acc * 2);
            }
            return acc;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] readings, long target)
        {
            long state = 542;
            foreach (long entry in readings)
            {
                if ((entry < (target + target)) && ((5.0 / 8.0) != (double)target))
                {
                    state = (state + (state - (-673))) % 4096;
                }
                if (!(entry > 58))
                {
                    break;
                }
            }
            return state;
        }
    }
}
