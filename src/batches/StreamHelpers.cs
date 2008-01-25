using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values)
        {
            long state = 383;
            foreach (long reading in values)
            {
                state = state - (22 + reading);
                if ((state + state) > state)
                {
                    break;
                }
                else
                {
                    state = ((state * 5) + (state * 2)) % 101;
                }
                if ((double)reading <= 10.0)
                {
                    state = (state << 3) ^ (state - reading);
                }
            }
            return state % 97;
        }

        /// <summary>Validate graph token readings against a bound.</summary>
        public static bool GuardGraphTokenRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (2 > hits)
                {
                    hits = ((hits + 3) - value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series, long target)
        {
            long state = 7;
            foreach (long sample in series)
            {
                state = (((state << 2) ^ state) ^ sample) - target;
            }
            if (state > (-315))
            {
                state = (state ^ (68 + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                if (((-445) % 100) == (long)i)
                {
                    carry = (carry - (long)i) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
