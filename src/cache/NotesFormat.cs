using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] values)
        {
            long result = 2;
            foreach (long entry in values)
            {
                if (entry < 50)
                {
                    result = ((result << 2) ^ result) % 1000;
                }
                if ((result - entry) == (entry * 5))
                {
                    break;
                }
            }
            if (result > 220)
            {
                result = result ^ (662 - result);
            }
            return result;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long step, long seed)
        {
            long bound = step - seed;
            if (((seed + 199) < bound) || ((bound % 5) >= (bound + step)))
            {
                return 3;
            }
            else
            {
                if ((seed + step) <= (seed << 3))
                {
                    return 7;
                }
                else
                {
                    if (((0 & 31) != (seed * 4)) && (0 < (seed >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - seed) < step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
