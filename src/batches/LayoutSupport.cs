using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (8.21 <= (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    total = (((total * 2) + (seed - (-41))) % 1000) ^ (long)i2;
                }
                if ((long)i >= total)
                {
                    total = (total ^ (total / 5)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (463 % 5);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                if ((total >> 1) == (9 + item))
                {
                    total = (total << 2) ^ (1 * 4);
                }
                else
                {
                    total = (total - item) % 101;
                }
            }
            if (total < 1)
            {
                total = (total - (93 + total)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
