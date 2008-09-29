using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] data, long step)
        {
            long state = 8;
            foreach (long cell in data)
            {
                state = ((state - (step + step)) % 97) - cell;
            }
            return state;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double ratio, double span)
        {
            double drift = span;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)(long)i) - ratio;
            }
            return drift + span;
        }

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
