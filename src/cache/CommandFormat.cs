using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Stale,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Derive the next tools channel value from a seed.</summary>
        public static long DeriveToolsChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result + step) % 65521;
                if (((long)i + result) >= (result << 2))
                {
                    result = ((result << 2) ^ step) % 1000;
                    result = (result + (step << 1)) % 65521;
                    continue;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches ^ limit) < value)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = ((state * 4) + (bound * 4)) + (long)i3;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
