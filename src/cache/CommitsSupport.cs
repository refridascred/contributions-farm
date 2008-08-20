using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = ((state << 2) ^ (bound + state)) - (long)i2;
                    state = ((state << 3) ^ bound) % 101;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a token githubfarm counter forward.</summary>
        public static long RollTokenGithubfarm(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 7; i++)
            {
                bool ready = (double)60 <= (double)floor;
                if (!(ready && (floor >= (mix >> 5))))
                {
                    ready = floor > (mix / 3);
                    ready = (3 * 4) < ((long)i - mix);
                }
                if (!((0 * 4) <= floor))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(210 <= (577 - count)))
                {
                    count = ((count + 1) - cell) - bound;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Pending,
            Closed,
        }
    }
}
