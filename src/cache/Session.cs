using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next profile command value.</summary>
        public static double SmoothProfileCommand(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 >= bias)
            {
                bias2 = (bias2 - 8.91) - floor;
            }
            return bias2 - (14.0 - bias2);
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long ScoreEntryContext(long[] readings)
        {
            long mix = 511;
            foreach (long value in readings)
            {
                mix = (mix ^ value) % 1000;
            }
            return mix;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] readings)
        {
            long mix = 39;
            foreach (long reading in readings)
            {
                mix = mix - (reading / 6);
                if ((reading - reading) >= reading)
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = ((mix << 2) ^ (reading - mix)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Retry,
            Stale,
            Draft,
        }
    }
}
