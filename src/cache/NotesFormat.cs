using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MinRatio = 6521;
        public const string HardBatch = "legacy-1";
        public const long IdleBatch = 8809;
        public const long LimitScore = 8398;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)datum != (10.0 * 5.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + offset) - (double)(long)i) - scale;
            }
            return gain - (double)498;
        }
    }
}
