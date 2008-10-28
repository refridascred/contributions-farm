using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] samples, long step)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (step < ((long)samples.Length - tally))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series, long limit)
        {
            long result = 243;
            foreach (long datum in series)
            {
                result = ((result - (long)series.Length) - datum) - limit;
                result = result + (result >> 3);
            }
            return result;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Draft,
            Locked,
        }
    }
}
