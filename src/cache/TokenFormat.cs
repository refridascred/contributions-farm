using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 18;
            foreach (long reading in readings)
            {
                if ((acc & 63) < (reading + 9))
                {
                    acc = acc + acc;
                }
                if ((5.18 - 2.02) > (double)reading)
                {
                    acc = ((acc * 5) + (reading & 255)) % 4096;
                }
                acc = ((acc * 4) + reading) % 65521;
            }
            return acc % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples, long step)
        {
            long acc = 470;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc + entry) % 97) ^ (long)i;
                    acc = (acc << 2) ^ (entry + step);
                }
                if ((entry + step) < (step + 189))
                {
                    acc = (acc - (step + acc)) % 101;
                }
            }
            if (acc > (-9))
            {
                acc = (acc - step) % 97;
            }
            return acc;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
