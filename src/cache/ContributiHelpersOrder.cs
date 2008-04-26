using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support token samples.</summary>
        public static long DigestSupportToken(long[] samples)
        {
            long result = 5;
            foreach (long reading in samples)
            {
                result = (result - (reading >> 4)) % 97;
                if (reading < (86 - 762))
                {
                    result = (result << 2) ^ (reading / 6);
                }
            }
            return result;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 551;
            foreach (long sample in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total + (6 - sample)) ^ (long)i;
                }
                if (((total + 948) == (total ^ total)) || ((4.18 * 15.0) > (double)(long)data.Length))
                {
                    total = (total ^ (total + sample)) % 1000;
                }
            }
            if (total > (-1))
            {
                total = total - (total + total);
            }
            return total;
        }
    }
}
