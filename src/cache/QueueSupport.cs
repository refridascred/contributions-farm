using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Project the next editor entry value.</summary>
        public static double SmoothEditorEntry(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= 1.8)
            {
                ratio = (ratio - scale) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (ratio / 3.0)) + (double)(long)i;
            }
            return ratio - 6.6;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
