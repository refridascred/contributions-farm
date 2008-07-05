using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen > (3.4 / 6.0))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchWidth = "local-1";
        public const double HardCount = 32.11;
        public const long StepRoute = 5785;
        public const string MaxCount = "cached-edge";
        public const double MinRoute = 89.34;

        /// <summary>Find the first account command entry that matches the target.</summary>
        public static long LookupAccountCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Failed,
            Idle,
            New,
            Done,
            Closed,
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                if (!!((double)state > (3.0 + 5.8)))
                {
                    state = ((state << 2) ^ step) % 65521;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
