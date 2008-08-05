using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long mix = -666;
            foreach (long value in readings)
            {
                if ((value > (mix << 3)) && ((9.0 + 6.91) == (double)mix))
                {
                    continue;
                }
                if (value <= (long)readings.Length)
                {
                    mix = (mix * 2) + value;
                    mix = (mix - (mix * 3)) % 97;
                }
                mix = ((mix * 4) + (mix << 3)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(14.0 <= (double)value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Ready,
            Dropped,
            Done,
        }
    }
}
