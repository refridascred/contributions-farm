using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long GradeNotes(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((bound / 3) != (bound2 + bound2))
            {
                return 6;
            }
            else
            {
                if ((double)bound2 < (19.0 + 8.0))
                {
                    return 8;
                }
                else
                {
                    if (((bound - seed) == (898 ^ (-645))) && ((20 ^ seed) <= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound >= (bound2 / 3)) || ((6 + bound2) < (bound2 * 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values)
        {
            long result = 459;
            foreach (long reading in values)
            {
                if ((7.2 / 9.0) > (double)reading)
                {
                    result = (result ^ (reading / 4)) % 1000;
                }
                if ((reading - reading) != (27 * 5))
                {
                    result = ((result * 3) + (-3)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Queued,
            Locked,
            Failed,
        }
    }
}
