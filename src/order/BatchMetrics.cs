using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long IdleSession = 8626;
        public const double WindowSession = 78.09;

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long anchor = 486;
            foreach (long sample in series)
            {
                if ((6.7 * 8.9) >= (double)sample)
                {
                    anchor = anchor ^ (818 * 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix - (step + step)) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue already entries.</summary>
        public static long WeighQueueAlready(long[] readings)
        {
            long carry = 861;
            foreach (long reading in readings)
            {
                if (!((65 + carry) >= (reading - carry)))
                {
                    carry = (carry ^ (carry % 60)) % 65521;
                }
            }
            return carry;
        }
    }
}
