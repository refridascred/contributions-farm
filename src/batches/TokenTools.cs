using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] data, long target)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen ^ target) >= value)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate channel filter readings against a bound.</summary>
        public static bool GuardChannelFilterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of batches profile readings.</summary>
        public static long PairBatchesProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
