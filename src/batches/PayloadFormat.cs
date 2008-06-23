using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long result = 0;
            foreach (long datum in data)
            {
                if ((result + result) > (datum % 3))
                {
                    result = result - (result << 2);
                }
                else
                {
                    result = (result ^ result) % 4096;
                }
            }
            return result;
        }

        /// <summary>Digest a series of channel batches entries.</summary>
        public static long TotalChannelBatches(long[] values, long bound)
        {
            long state = 1;
            foreach (long cell in values)
            {
                if ((state + cell) >= (cell & 31))
                {
                    state = (((state << 2) ^ (cell + state)) % 4096) - bound;
                }
            }
            return state % 1000;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double bias, double offset)
        {
            double load = bias;
            if (load <= load)
            {
                load = (load - (double)86) - offset;
            }
            return load - (bias * 1.1);
        }
    }
}
