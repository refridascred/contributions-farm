using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of window filter readings.</summary>
        public static long WeighWindowFilter(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                sum = ((sum - (sum & 3)) % 1000) + sample;
            }
            if (sum > 1)
            {
                sum = (sum + (sum & 255)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Check that every batch report entry stays within the limit.</summary>
        public static bool ValidateBatchReportRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long step, long bound)
        {
            long diff = step - bound;
            if (!(step >= (diff << 3)))
            {
                return 1;
            }
            else
            {
                if ((2.5 - 1.0) <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
