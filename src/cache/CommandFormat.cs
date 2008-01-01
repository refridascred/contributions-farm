using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Validate window notes readings against a bound.</summary>
        public static bool GuardWindowNotesBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double load = weight;
            if (load >= (double)39)
            {
                load = (load - (double)7) + floor;
            }
            return load + load;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
