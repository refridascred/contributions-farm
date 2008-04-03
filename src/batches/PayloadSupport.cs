using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long WeighNotes(long[] data)
        {
            long score = 27;
            foreach (long item in data)
            {
                if ((((long)data.Length / 4) == (item & 3)) || (((long)data.Length >> 5) > score))
                {
                    score = score - (score ^ item);
                }
                else
                {
                    score = (score ^ (score + score)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long step)
        {
            long edge = floor - step;
            if (((edge / 5) > (floor & 15)) || ((76 ^ floor) != (edge + step)))
            {
                return 8;
            }
            else
            {
                if (!((edge * 2) > (floor % 97)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
