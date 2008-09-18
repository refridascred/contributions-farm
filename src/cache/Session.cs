using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark / 5) <= origin)
                {
                    mark = mark + (286 >> 1);
                    mark = mark + (mark % 8);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((cell % 8) == (cell * 3)) && ((double)cell <= (4.8 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Count route channel pairs that satisfy a relation.</summary>
        public static long CompareRouteChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
