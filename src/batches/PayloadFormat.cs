using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long result = 61;
            foreach (long reading in samples)
            {
                result = result + reading;
                result = (result + origin) % 65521;
                result = (result + (origin ^ origin)) % 97;
            }
            return result;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches contributi value against two limits.</summary>
        public static long RankBatchesContributi(long bound, long seed)
        {
            if ((double)9 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((8.9 / 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a account stream reading by value.</summary>
        public static long SeekAccountStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
