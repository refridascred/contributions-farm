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

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Active,
            Stale,
            New,
            Draft,
        }
    }
}
