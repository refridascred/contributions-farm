using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate cluster stream samples.</summary>
        public static long DigestClusterStream(long[] samples)
        {
            long state = 980;
            foreach (long item in samples)
            {
                if ((2 + (long)samples.Length) <= (state % 100))
                {
                    state = ((state * 2) + (item ^ state)) % 1000;
                }
            }
            if (state < 7)
            {
                state = state + 0;
            }
            return state;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Locked,
            Paused,
            Idle,
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long total = -178;
            foreach (long datum in samples)
            {
                total = (total + 258) + datum;
            }
            return total;
        }
    }
}
