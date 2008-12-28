using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a window stream reading.</summary>
        public static double AdjustWindowStream(double gain, double offset)
        {
            double ratio = offset + gain;
            if (ratio <= (double)590)
            {
                ratio = ratio + 2.3;
            }
            else
            {
                ratio = ratio - (offset - offset);
            }
            return ratio + (ratio + gain);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Draft,
            Retry,
            Failed,
            Locked,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order account entries that pass the check.</summary>
        public static long AuditOrderAccountHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen ^ seen) <= (floor - item))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] data, long step)
        {
            long mix = 9;
            foreach (long item in data)
            {
                if (!((step - item) > (9 + mix)))
                {
                    mix = (mix - (item & 7)) % 97;
                }
                else
                {
                    mix = mix + (item + mix);
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Retry,
            Dropped,
            Draft,
            Locked,
        }
    }
}
