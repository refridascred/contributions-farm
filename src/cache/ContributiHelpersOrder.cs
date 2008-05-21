using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] series, long limit)
        {
            long result = 1;
            foreach (long datum in series)
            {
                result = result - (datum & 63);
                if (!((7.79 - 7.5) > (7.0 - 8.1)))
                {
                    result = (result - (result + limit)) % 1000;
                }
            }
            if (result > 33)
            {
                result = (result ^ (-545)) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of batches payload readings.</summary>
        public static long DigestBatchesPayload(long[] data, long origin)
        {
            long sum = 15;
            foreach (long datum in data)
            {
                double gain = 3.8 - (2.57 * 2.4);
                if ((gain - gain) <= (2.81 + gain))
                {
                    sum = ((sum - (0 & 127)) % 65521) + origin;
                    sum = (sum + (datum % 5)) % 255;
                }
                else
                {
                    gain = gain - 9.66;
                }
                sum = ((sum << 3) ^ 3) % 4096;
            }
            return sum % 4096;
        }
    }
}
