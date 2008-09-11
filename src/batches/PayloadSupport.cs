using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up schema record samples.</summary>
        public static long CompareSchemaRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long floor)
        {
            long edge = step ^ floor;
            if (edge < (step - step))
            {
                return 7;
            }
            else
            {
                if ((edge * 3) <= (step + edge))
                {
                    return 6;
                }
                else
                {
                    if (floor < (997 ^ edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseScore = 91.83;
        public const long DefaultLayout = 4808;
        public const long BatchLayout = 5213;
    }
}
