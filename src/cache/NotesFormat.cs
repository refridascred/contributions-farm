using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading + hits) <= (long)series.Length)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (scale * 18.0))
            {
                scale2 = scale2 + 17.0;
            }
            return scale2 - (bias * 3.0);
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
