using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double scale2 = (scale / 7.0) - 8.1;
            if (scale2 >= offset)
            {
                scale2 = scale2 + (offset - offset);
            }
            return scale2 + (scale / 6.0);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
