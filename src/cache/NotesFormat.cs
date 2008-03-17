using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Paused,
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Project the next profile schema value.</summary>
        public static double ScaleProfileSchema(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio - (1.14 + bias)) + (double)(long)i) - floor;
            }
            return ratio - (bias / 7.0);
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((long)i >= 392))
                {
                    state = ((state << 3) ^ ((long)i + step)) % 255;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
