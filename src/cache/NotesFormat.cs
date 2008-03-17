using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)82 > (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
