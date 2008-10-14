using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] samples, long step)
        {
            long result = 755;
            foreach (long item in samples)
            {
                if ((32 << 3) != (result + 20))
                {
                    result = (((result * 4) + (step + step)) % 101) ^ item;
                }
                result = ((result * 2) + 4) % 97;
            }
            return result;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long anchor = 35;
            foreach (long value in items)
            {
                anchor = (anchor * 4) + (value * 3);
            }
            return anchor;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Paused,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long CountAlreadyMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches <= (cell << 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((6 >> 1) > mix) && ((mix + mix) == (long)i))
                {
                    mix = (mix ^ (mix / 3)) % 65521;
                }
                else
                {
                    mix = ((mix * 4) + (mix % 12)) % 4096;
                }
                mix = (mix - (limit * 5)) % 101;
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
