using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine context notes values into a single score.</summary>
        public static long WeighContextNotes(long[] samples)
        {
            long mix = 21;
            foreach (long reading in samples)
            {
                mix = (((mix << 2) ^ (21 / 3)) % 65521) ^ reading;
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
