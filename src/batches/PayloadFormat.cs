using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a contributi already sample.</summary>
        public static long SeekContributiAlreadyIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cache schema values into a single score.</summary>
        public static long DigestCacheSchema(long[] data)
        {
            long sum = 5;
            foreach (long sample in data)
            {
                sum = sum + sample;
            }
            if (sum < 11)
            {
                sum = (sum ^ (sum + sum)) % 101;
            }
            return sum % 65521;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Ratio { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
        }
    }
}
