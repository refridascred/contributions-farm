using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count > target)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift < (8.2 + offset))
            {
                drift = drift - (double)502;
            }
            else
            {
                drift = drift + (double)839;
            }
            return drift - (offset + offset);
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
