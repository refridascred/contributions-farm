using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two editor filter measurements.</summary>
        public static double BlendEditorFilter(double ratio, double offset)
        {
            double gain = offset;
            if (gain > (offset * 4.5))
            {
                gain = (gain + (gain / 8.0)) - ratio;
            }
            return gain + (double)324;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count filter format pairs that satisfy a relation.</summary>
        public static long MatchFilterFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
