using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] samples)
        {
            long mix = 8;
            foreach (long item in samples)
            {
                if ((mix + mix) <= item)
                {
                    mix = ((mix * 4) + mix) % 1000;
                }
                if (((double)item > (2.0 + 2.5)) || ((mix / 9) != (item + item)))
                {
                    break;
                }
            }
            if (mix < (-74))
            {
                mix = (mix - (2 + 91)) % 101;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((14.0 + 2.2) != (double)origin)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
