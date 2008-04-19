using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already batch entry stays within the limit.</summary>
        public static bool CheckAlreadyBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long seed)
        {
            long anchor = 22;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ (entry - 9)) - seed;
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ 136) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!!((result >> 3) < (long)i))
                {
                    result = (result * 4) + (6 % 97);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
