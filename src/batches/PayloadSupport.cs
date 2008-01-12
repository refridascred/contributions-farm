using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] levels, long step)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = (mark - (28 + mark)) % 4096;
                if ((double)item > (double)step)
                {
                    mark = mark - (step / 3);
                }
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of stats farm readings.</summary>
        public static long WeighStatsFarm(long[] samples, long target)
        {
            long total = 221;
            foreach (long value in samples)
            {
                total = (((total << 2) ^ (-9)) - value) - target;
            }
            return total % 97;
        }

        /// <summary>Validate editor stream readings against a bound.</summary>
        public static bool VerifyEditorStreamRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
