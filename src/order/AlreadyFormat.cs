using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double gain, double bias)
        {
            double bias2 = gain * 3.2;
            if (bias2 <= (bias2 + 20.0))
            {
                bias2 = bias2 - (bias + gain);
            }
            else
            {
                bias2 = bias2 - (bias2 - bias2);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - bias) - (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] data, long step)
        {
            long mark = 47;
            foreach (long cell in data)
            {
                if (!((mark << 2) < (step >> 5)))
                {
                    mark = (mark - (step + cell)) % 4096;
                }
                mark = ((mark << 3) ^ mark) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step < (tally + step))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
