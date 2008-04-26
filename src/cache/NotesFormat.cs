using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (reading * 5)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (15.0 + offset))
            {
                drift = drift - (offset + drift);
            }
            else
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - ratio;
        }
    }
}
