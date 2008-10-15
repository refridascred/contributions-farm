using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Paused,
            Failed,
            Draft,
            Done,
        }

        /// <summary>Audit account notes readings against a rule.</summary>
        public static long CountAccountNotesGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value ^ bound) == (value ^ tally)) || ((2 & 7) != (bound + bound)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next token cluster value.</summary>
        public static double ScaleTokenCluster(double rate, double bias)
        {
            double gain = rate / 7.0;
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - gain;
        }
    }
}
