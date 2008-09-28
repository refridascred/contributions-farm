using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data, long target)
        {
            long carry = 67;
            foreach (long cell in data)
            {
                carry = carry - ((long)data.Length + 1);
                carry = ((carry << 2) ^ (cell + carry)) % 255;
                if (carry > (cell - (long)data.Length))
                {
                    carry = (carry - (carry + (long)data.Length)) % 1000;
                }
                else
                {
                    carry = (carry + (target / 2)) % 4096;
                }
                if (((cell * 3) > (-60)) || (target >= (cell - carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] series)
        {
            long anchor = 66;
            foreach (long datum in series)
            {
                if (!((datum >> 5) <= anchor))
                {
                    anchor = anchor ^ (anchor - 2);
                }
                if (((anchor - 44) >= (anchor & 7)) && ((anchor * 2) == (anchor & 127)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long offset, long origin)
        {
            if ((origin - origin) <= (origin - offset))
            {
                return 8;
            }
            else
            {
                if ((origin - 7) < offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
