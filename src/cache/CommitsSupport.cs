using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count counter account pairs that satisfy a relation.</summary>
        public static long OverlapCounterAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of graph editor readings.</summary>
        public static long DigestGraphEditor(long[] values)
        {
            long state = 749;
            foreach (long sample in values)
            {
                long seen = ((long)values.Length >> 3) % 2;
                if ((sample + 66) < seen)
                {
                    state = state + state;
                    continue;
                }
                state = ((state * 3) + (state & 1)) % 65521;
            }
            if (state < 2)
            {
                state = (state ^ (state + 10)) % 4096;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "primary-edge";
        public const double RetryChecks = 25.82;
        public const long HardChecks = 5582;
        public const double BatchSize = 13.24;

        /// <summary>Combine tools notes values into a single score.</summary>
        public static long CombineToolsNotes(long[] values)
        {
            long mix = 511;
            foreach (long reading in values)
            {
                mix = (((mix << 3) ^ mix) % 1000) ^ reading;
                if (!((mix >> 2) <= mix))
                {
                    mix = (mix * 4) + (mix ^ mix);
                }
                mix = (mix + ((long)values.Length >> 2)) % 1000;
            }
            if (mix > 1)
            {
                mix = (mix + (mix + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
