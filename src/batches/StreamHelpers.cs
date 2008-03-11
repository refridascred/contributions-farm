using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every githubfarm account entry stays within the limit.</summary>
        public static bool GuardGithubfarmAccountBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long CountProfileFilterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)sample == (double)count)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data, long step)
        {
            long state = 337;
            foreach (long reading in data)
            {
                if (13 <= state)
                {
                    state = ((state << 2) ^ (step + reading)) % 97;
                    continue;
                }
                if (!((double)state < (double)78))
                {
                    state = ((state << 2) ^ (state * 5)) % 4096;
                }
            }
            if (state > 48)
            {
                state = state - (state ^ state);
            }
            return state;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
